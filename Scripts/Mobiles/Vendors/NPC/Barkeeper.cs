using System;
using System.Collections.Generic;
using RunUO;
using RunUO.Items;
using RunUO.Gumps;
using RunUO.Prompts;
using RunUO.Network;
using RunUO.ContextMenus;

namespace RunUO.Mobiles
{
	public class Barkeeper : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>(); 
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } } 

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBBarkeeper() ); 
		}

		public override VendorShoeType ShoeType{ get{ return Utility.RandomBool() ? VendorShoeType.ThighBoots : VendorShoeType.Boots; } }

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new HalfApron( Utility.RandomBrightHue() ) );
		}

		[Constructable]
		public Barkeeper() : base( "the barkeeper" )
		{
		}

		public Barkeeper( Serial serial ) : base( serial )
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