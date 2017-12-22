<Query Kind="Statements">
  <Reference Relative="..\OData\MedallionOData\MedallionOData\bin\Debug\Newtonsoft.Json.dll">&lt;MyDocuments&gt;\Interests\CS\OData\MedallionOData\MedallionOData\bin\Debug\Newtonsoft.Json.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Web.dll</Reference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Collections.Specialized</Namespace>
  <Namespace>System.Runtime.Remoting.Messaging</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var readme = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"Interests\CS\Escape\readme.md");
var text = File.ReadAllText(readme);
var replaced = Regex.Replace(text, @"v=(?<version>\d+)", m => m.Value.Replace(m.Groups["version"].Value, (int.Parse(m.Groups["version"].Value) + 1).ToString()));
File.WriteAllText(readme, replaced);