using Tyuiu.RotachAO.Sprint4.Task6.V28.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task6.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        var word = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
        string[] res = ds.Calculate(word);
        string[] wait = { "Река", "Лужа", "Море" };
        Assert.AreEqual(wait, res);
    } 
} 
