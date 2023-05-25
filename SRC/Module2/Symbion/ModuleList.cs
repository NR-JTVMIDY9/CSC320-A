using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Symbion {
	[XmlType("ModuleCatalog")]
	public class ModuleList {
		[XmlArray("Modules")]
		public List<ModuleItem> Items { get; set; }
		public ModuleList() {
			Items = new List<ModuleItem>();
		}
		//public void Save(string path) {
		//	XmlSerializer serializer = new XmlSerializer(typeof(ModuleList));
		//	FileStream stream = new FileStream(
		//		path, FileMode.Create, FileAccess.Write);
		//	try { serializer.Serialize(stream, this); }
		//	finally { stream.Close(); }
		//}
		public void Save(string path) {
			XmlSerializer serializer = new XmlSerializer(typeof(ModuleList));
			using (FileStream stream = new FileStream(
				path, FileMode.Create, FileAccess.Write)) {
				serializer.Serialize(stream, this);
			}
		}

		public static ModuleList Load(string path) {
			if (!File.Exists(path)) return new ModuleList();
			XmlSerializer serializer = new XmlSerializer(typeof(ModuleList));
			using(FileStream stream = new FileStream(
				path, FileMode.Open, FileAccess.Read)) {
				//	return (ModuleList)serializer.Deserialize(stream);
				ModuleList list = serializer.Deserialize(stream) as ModuleList;
				//	if (list == null) return new ModuleList();
				if (list == null) throw new Exception(
					"Error loading invalid module list.");
				return list;
			}
		}
	}
}
