﻿using System;
using System.Collections.Generic;
using System.Linq;
using Roadkill.Core.Plugins;

namespace Roadkill.Tests.Unit.StubsAndMocks
{
	public class PluginFactoryMock : IPluginFactory
	{
		public List<TextPlugin> EnabledTextPlugins { get; set; }
		public List<TextPlugin> TextPlugins { get; set; }
		public List<SpecialPagePlugin> SpecialPages { get; set; }

		public PluginFactoryMock()
		{
			EnabledTextPlugins = new List<TextPlugin>();
			TextPlugins = new List<TextPlugin>();
			SpecialPages = new List<SpecialPagePlugin>();
		}

		public IEnumerable<TextPlugin> GetTextPlugins()
		{
			return TextPlugins;
		}

		public IEnumerable<TextPlugin> GetEnabledTextPlugins()
		{
			return EnabledTextPlugins;
		}

		public void RegisterTextPlugin(TextPlugin plugin)
		{
			TextPlugins.Add(plugin);
			EnabledTextPlugins.Add(plugin);
		}

		public TextPlugin GetTextPlugin(string id)
		{
			return TextPlugins.FirstOrDefault(x => x.Id == id);
		}

		public void UpdateInstance(TextPlugin plugin)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SpecialPagePlugin> GetSpecialPagePlugins()
		{
			return SpecialPages;
		}

		public SpecialPagePlugin GetSpecialPagePlugin(string name)
		{
			return SpecialPages.FirstOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
