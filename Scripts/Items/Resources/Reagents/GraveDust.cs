using System;
using RunUO;
using RunUO.Items;

namespace RunUO.Items
{
	public class GraveDust : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber { get { return LabelNumber; } }
		bool ICommodity.IsDeedable { get { return true; } }

		[Constructable]
		public GraveDust() : this( 1 )
		{
		}

		[Constructable]
		public GraveDust( int amount ) : base( 0xF8F, amount )
		{
		}

		public GraveDust( Serial serial ) : base( serial )
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