using System;
using System.Collections.Generic;
using System.Text;
using RunUO.Factions;

namespace RunUO.Ethics.Hero
{
	public sealed class HeroEthic : Ethic
	{
		public HeroEthic()
		{
			m_Definition = new EthicDefinition(
					0x482,
					"Hero", "(Hero)",
					"I will defend the virtues",
					new Power[]
					{
						new HolySense(),
						new HolyItem(),
						new SummonFamiliar(),
						new HolyBlade(),
						new Bless(),
						new HolyShield(),
						new HolySteed(),
						new HolyWord()
					}
				);
		}

		public override bool IsEligible( Mobile mob )
		{
			if ( mob.Kills >= 5 )
				return false;

			Faction fac = Faction.Find( mob );

			return ( fac is TrueBritannians || fac is CouncilOfMages );
		}
	}
}