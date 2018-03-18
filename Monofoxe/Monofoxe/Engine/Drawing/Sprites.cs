using System;
using System.Collections.Generic;
using Monofoxe.Engine.Drawing;

namespace Monofoxe.Engine.Drawing
{
	public static class Sprites
	{
		#region sprites
		public static Sprite Barrel;
		public static Sprite BarrelParts;
		public static Sprite BroWoolhat;
		public static Sprite BubbleStrip2;
		public static Sprite Bucket;
		public static Sprite Cabbage1Smashed;
		public static Sprite Cabbage2;
		public static Sprite Cabbage2Smashed;
		public static Sprite Cabbage3;
		public static Sprite Cabbage3Smashed;
		public static Sprite Cabbage0;
		public static Sprite Chiggin;
		public static Sprite Cleric;
		public static Sprite ClericBench;
		public static Sprite ClericHat;
		public static Sprite Ded1;
		public static Sprite Ded1Dmg;
		public static Sprite Demon;
		public static Sprite DemonDmg;
		public static Sprite DemonFire;
		public static Sprite SpriteFont;
		public static Sprite TestKitten;
		public static Sprite Scene1Knight;
		public static Sprite Scene2;
		public static Sprite Scene3Bkg;
		public static Sprite Scene3Sword;
		public static Sprite Scene4Bkg;
		public static Sprite Scene4Bucket;
		public static Sprite Scene4BucketShadow;
		public static Sprite Scene4Knight;
		public static Sprite Sc5KnightSword;
		public static Sprite Scene1KnightBody;
		public static Sprite Scene1KnightFaceStrip3;
		public static Sprite Scene1TreesBkgLayer1;
		public static Sprite Scene1TreesBkgLayer2;
		public static Sprite Scene1TreesBkgLayer3;
		public static Sprite Scene2Bkg;
		public static Sprite Scene2Knight;
		public static Sprite Scene2Reflection;
		public static Sprite Scene3Bkg_0;
		public static Sprite Scene3Ground;
		public static Sprite Scene3Hill;
		public static Sprite Scene3TreeLeft;
		public static Sprite Scene3TreeRight;
		public static Sprite Scene4Bkg_0;
		public static Sprite Scene4Knight_0;
		public static Sprite Scene5Bkg;
		public static Sprite Scene5BkgStrip2;
		public static Sprite Basket;
		public static Sprite Bench;
		public static Sprite BenchShadow;
		public static Sprite BirdieBody;
		public static Sprite BirdieLegs;
		public static Sprite BirdieWing;
		public static Sprite Boss;
		public static Sprite Bottle;
		public static Sprite Boulder1;
		public static Sprite Boulder2;
		public static Sprite Boulder3;
		public static Sprite Bro;
		public static Sprite BroDmg;
		public static Sprite BroGlasses;
		public static Sprite BroHair;
		public static Sprite BroHat;
		public static Sprite BstGam;
		#endregion sprites
		
		public static void Init(Dictionary<string, Frame[]> frames)
		{
			#region sprite_constructors
			
			Barrel = new Sprite(frames["barrel"], 0, 0);
			BarrelParts = new Sprite(frames["barrel_parts"], 0, 0);
			BroWoolhat = new Sprite(frames["bro_woolhat"], 0, 0);
			BubbleStrip2 = new Sprite(frames["bubble_strip2"], 0, 0);
			Bucket = new Sprite(frames["bucket"], 0, 0);
			Cabbage1Smashed = new Sprite(frames["cabbage1_smashed"], 0, 0);
			Cabbage2 = new Sprite(frames["cabbage2"], 0, 0);
			Cabbage2Smashed = new Sprite(frames["cabbage2_smashed"], 0, 0);
			Cabbage3 = new Sprite(frames["cabbage3"], 0, 0);
			Cabbage3Smashed = new Sprite(frames["cabbage3_smashed"], 0, 0);
			Cabbage0 = new Sprite(frames["cabbage_0"], 0, 0);
			Chiggin = new Sprite(frames["chiggin"], 0, 0);
			Cleric = new Sprite(frames["cleric"], 0, 0);
			ClericBench = new Sprite(frames["cleric_bench"], 0, 0);
			ClericHat = new Sprite(frames["cleric_hat"], 25, 18);
			Ded1 = new Sprite(frames["ded1"], 0, 0);
			Ded1Dmg = new Sprite(frames["ded1_dmg"], 0, 0);
			Demon = new Sprite(frames["demon"], 0, 0);
			DemonDmg = new Sprite(frames["demon_dmg"], 0, 0);
			DemonFire = new Sprite(frames["demon_fire"], 32, 32);
			SpriteFont = new Sprite(frames["sprite_font"], 0, 0);
			TestKitten = new Sprite(frames["test kitten"], 0, 0);
			Scene1Knight = new Sprite(frames["intro/scene1_knight"], 0, 0);
			Scene2 = new Sprite(frames["intro/scene2"], 0, 0);
			Scene3Bkg = new Sprite(frames["intro/scene3_bkg"], 0, 0);
			Scene3Sword = new Sprite(frames["intro/scene3_sword"], 0, 0);
			Scene4Bkg = new Sprite(frames["intro/scene4_bkg"], 0, 0);
			Scene4Bucket = new Sprite(frames["intro/scene4_bucket"], 0, 0);
			Scene4BucketShadow = new Sprite(frames["intro/scene4_bucket_shadow"], 0, 0);
			Scene4Knight = new Sprite(frames["intro/scene4_knight"], 0, 0);
			Sc5KnightSword = new Sprite(frames["outro/sc5_knight_sword"], 0, 0);
			Scene1KnightBody = new Sprite(frames["outro/scene1_knight_body"], 0, 0);
			Scene1KnightFaceStrip3 = new Sprite(frames["outro/scene1_knight_face_strip3"], 0, 0);
			Scene1TreesBkgLayer1 = new Sprite(frames["outro/scene1_trees_bkg_layer1"], 0, 0);
			Scene1TreesBkgLayer2 = new Sprite(frames["outro/scene1_trees_bkg_layer2"], 0, 0);
			Scene1TreesBkgLayer3 = new Sprite(frames["outro/scene1_trees_bkg_layer3"], 0, 0);
			Scene2Bkg = new Sprite(frames["outro/scene2_bkg"], 0, 0);
			Scene2Knight = new Sprite(frames["outro/scene2_knight"], 0, 0);
			Scene2Reflection = new Sprite(frames["outro/scene2_reflection"], 0, 0);
			Scene3Bkg_0 = new Sprite(frames["outro/scene3_bkg"], 0, 0);
			Scene3Ground = new Sprite(frames["outro/scene3_ground"], 0, 0);
			Scene3Hill = new Sprite(frames["outro/scene3_hill"], 0, 0);
			Scene3TreeLeft = new Sprite(frames["outro/scene3_tree_left"], 0, 0);
			Scene3TreeRight = new Sprite(frames["outro/scene3_tree_right"], 0, 0);
			Scene4Bkg_0 = new Sprite(frames["outro/scene4_bkg"], 0, 0);
			Scene4Knight_0 = new Sprite(frames["outro/scene4_knight"], 0, 0);
			Scene5Bkg = new Sprite(frames["outro/scene5_bkg"], 0, 0);
			Scene5BkgStrip2 = new Sprite(frames["outro/scene5_bkg_strip2"], 0, 0);
			Basket = new Sprite(frames["Stuff/basket"], 0, 0);
			Bench = new Sprite(frames["Stuff/bench"], 0, 0);
			BenchShadow = new Sprite(frames["Stuff/bench_shadow"], 0, 0);
			BirdieBody = new Sprite(frames["Stuff/birdie_body"], 0, 0);
			BirdieLegs = new Sprite(frames["Stuff/birdie_legs"], 0, 0);
			BirdieWing = new Sprite(frames["Stuff/birdie_wing"], 0, 0);
			Boss = new Sprite(frames["Stuff/boss"], 0, 0);
			Bottle = new Sprite(frames["Stuff/bottle"], 0, 0);
			Boulder1 = new Sprite(frames["Stuff/boulder1"], 0, 0);
			Boulder2 = new Sprite(frames["Stuff/boulder2"], 0, 0);
			Boulder3 = new Sprite(frames["Stuff/boulder3"], 0, 0);
			Bro = new Sprite(frames["Stuff/bro"], 0, 0);
			BroDmg = new Sprite(frames["Stuff/bro_dmg"], 0, 0);
			BroGlasses = new Sprite(frames["Stuff/bro_glasses"], 0, 0);
			BroHair = new Sprite(frames["Stuff/bro_hair"], 0, 0);
			BroHat = new Sprite(frames["Stuff/bro_hat"], 0, 0);
			BstGam = new Sprite(frames["Textures/bst_gam"], 0, 0);
			
			#endregion sprite_constructors
		}
	}
}
