﻿using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

/*
 * FUTURE NOTE:
 * To create Pipeline Extension project,
 * choose C# Class Library template,
 * then reference Monogame for Desktop GL
 * and get Monogame.Framework.Content.Pipeline
 * from NuGet.
 * 
 * To add library to pipeline project, reference
 * dll with project name.
 */
namespace Pipefoxe.SpriteGroup
{
	/// <summary>
	/// Sprite group importer. Parses json config, and loads textures,
	/// which will be passed to AtlasProcessor.
	/// </summary>
	[ContentImporter(".atlas", DefaultProcessor = "SpriteGroupProcessor", 
	DisplayName = "Sprite Group Importer - Monofoxe")]
	public class SpriteGroupImporter : ContentImporter<SpriteGroupData>
	{
		public override SpriteGroupData Import(string filename, ContentImporterContext context)
		{
			var groupData = new SpriteGroupData();
			
			string[] textureRegex;

			#region Parsing config.	
			try
			{
				var json = File.ReadAllText(filename);
				JToken configData = JObject.Parse(json);

				groupData.AtlasSize = Int32.Parse(configData["atlasSize"].ToString());
				groupData.TexturePadding = Int32.Parse(configData["texturePadding"].ToString());
				groupData.RootDir = Path.GetDirectoryName(filename) + '/' + configData["rootDir"].ToString();
				groupData.GroupName = Path.GetFileNameWithoutExtension(filename);
				groupData.ClassTemplatePath = configData["classTemplatePath"].ToString();
				groupData.ClassOutputDir = configData["classOutputDir"].ToString();

				SpriteGroupWriter.DebugMode = (configData["debugMode"].ToString() == "true");
				SpriteGroupWriter.DebugDir = Environment.CurrentDirectory + "/" + groupData.GroupName + "_dbg";

				JArray textureWildcards = (JArray)configData["singleTexturesWildcards"];

				textureRegex = new string[textureWildcards.Count];
				for(var i = 0; i < textureWildcards.Count; i += 1)
				{
					textureRegex[i] = WildCardToRegular(textureWildcards[i].ToString());
				}
			}
			catch(Exception)
			{
				throw(new InvalidContentException("Incorrect JSON format!"));
			}
			#endregion Parsing config.
			
			
			ImportTextures(groupData.RootDir, "", groupData, textureRegex);

			return groupData;
			
		}



		/// <summary>
		/// Recursively looks into root dir and loads textures. 
		/// </summary>
		/// <param name="dirPath">Full path to directory.</param>
		/// <param name="dirName">Full path minus root.</param>
		/// <param name="groupData">SpriteGroupData object.</param>
		/// <param name="textureRegex">Regex filter. Determines if texture is part of atlas or single.</param>
		private void ImportTextures(string dirPath, string dirName, SpriteGroupData groupData, string[] textureRegex)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

			foreach(FileInfo file in dirInfo.GetFiles("*.png"))
			{
				var spr = new RawSprite();
				spr.Name = dirName + Path.GetFileNameWithoutExtension(file.Name);
				spr.RawTexture = Image.FromFile(file.FullName);

				var configPath = Path.ChangeExtension(file.FullName, ".json");
				

				#region Reading config.
				/*
				 * Just reading sprite jsons.
				 * If you want to add more parameters, begin from here.
				 */
				if (File.Exists(configPath))
				{
					try
					{
						var conf = File.ReadAllText(configPath);
						JToken confData = JObject.Parse(conf); 			

						spr.FramesH = Int32.Parse(confData["h"].ToString());
						spr.FramesV = Int32.Parse(confData["v"].ToString());
						
						if (spr.FramesH < 1 || spr.FramesV < 1) // Frame amount cannot be lesser than 1.
						{
							throw(new Exception());
						}

						spr.Offset = new Point(Int32.Parse(confData["offset_x"].ToString()), Int32.Parse(confData["offset_y"].ToString()));
					}
					catch(Exception)
					{
						throw(new Exception("Error while pasring sprite JSON for file: " + file.Name));
					}
				}
				#endregion Reading config.
				

				if (PathMatchesRegex('/' + dirName + '/' + file.Name, textureRegex)) // Separating atlas sprites from single textures.
				{
					groupData.SingleTextures.Add(spr);
				}
				else
				{
					groupData.Sprites.Add(spr);
				}
			}


			// Recursively repeating for all subdirectories.
			foreach(DirectoryInfo dir in dirInfo.GetDirectories())
			{
				ImportTextures(dir.FullName, dirName + dir.Name + '/', groupData, textureRegex);
			}
			// Recursively repeating for all subdirectories.

		}
		


		private string WildCardToRegular(string value) =>
			"^" + Regex.Escape(value).Replace("\\*", ".*") + "$"; 
		


		/// <summary>
		/// Checks if path matches regex filter.
		/// </summary>
		private bool PathMatchesRegex(string path, string[] regexArray)
		{
			var safePath = path.Replace('\\', '/'); // Just to not mess with regex and wildcards.

			foreach(string regex in regexArray)
			{
				if (Regex.IsMatch(safePath, regex, RegexOptions.IgnoreCase))
				{
					return true;
				}
			}
			return false;
		}
		
	}
}