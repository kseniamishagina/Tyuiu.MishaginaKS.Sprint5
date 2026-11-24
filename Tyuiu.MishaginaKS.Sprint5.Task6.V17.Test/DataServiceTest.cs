using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task6.V17.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task6.V17.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedLoadFromDataFile()

    {
        DataService ds = new DataService();

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V17.txt");
        File.WriteAllText(path, "Это  пример  строки с лишними пробелами.");

        int res = ds.LoadFromDataFile(path);
        int wait = 2;

        Assert.AreEqual(wait, res);
    }
}
