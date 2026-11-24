using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task4.V11.Lib;
namespace Tyuiu.MishaginaKS.Sprint5.Task4.V11.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void CheckedLoadFromDataFile()

    {
        DataService ds = new DataService();

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V11.txt");
        File.WriteAllText(path, "2.61");

        double res = ds.LoadFromDataFile(path);
        double wait = 3.913;

        Assert.AreEqual(wait, res);
    }
}

