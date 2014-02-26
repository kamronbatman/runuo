using System;
using RunUO;
using RunUO.Prompts;

namespace RunUO.Multis
{
	public class RenameBoatPrompt : Prompt
	{
		private BaseBoat m_Boat;

		public RenameBoatPrompt( BaseBoat boat )
		{
			m_Boat = boat;
		}

		public override void OnResponse( Mobile from, string text )
		{
			m_Boat.EndRename( from, text );
		}
	}
}