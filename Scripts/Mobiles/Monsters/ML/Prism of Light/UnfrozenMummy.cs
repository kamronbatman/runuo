using System;
using RunUO;
using RunUO.Items;

namespace RunUO.Mobiles
{
	[CorpseName( "an unfrozen mummy corpse" )]
	public class UnfrozenMummy : BaseCreature
	{
		[Constructable]
		public UnfrozenMummy()
			: base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.4, 0.8 )
		{
			Name = "an unfrozen mummy";
			Body = 0x9B;
			Hue = 0x480;
			BaseSoundID = 0x1D7;

			SetStr( 450, 500 );
			SetDex( 200, 250 );
			SetInt( 800, 850 );

			SetHits( 1500 );

			SetDamage( 16, 20 );

			SetDamageType( ResistanceType.Physical, 0 );
			SetDamageType( ResistanceType.Energy, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 35, 40 );
			SetResistance( ResistanceType.Fire, 20, 30 );
			SetResistance( ResistanceType.Cold, 60, 80 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 70, 80 );

			SetSkill( SkillName.Wrestling, 90.0, 100.0 );
			SetSkill( SkillName.Tactics, 100.0 );
			SetSkill( SkillName.MagicResist, 250.0 );
			SetSkill( SkillName.Magery, 50.0, 60.0 );
			SetSkill( SkillName.EvalInt, 50.0, 60.0 );
			SetSkill( SkillName.Meditation, 80.0 );

			Fame = 25000;
			Karma = -25000;

			PackArcaneScroll( 0, 2 );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 2 );
			// TODO: uncomment once added
			//AddLoot( LootPack.Parrot );
		}

		/*
		// TODO: uncomment once added
		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			if ( Utility.RandomDouble() < 0.6 )
				c.DropItem( new BrokenCrystals() );

			if ( Utility.RandomDouble() < 0.1 )
				c.DropItem( new ParrotItem() );
		}
		*/

		public UnfrozenMummy( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
