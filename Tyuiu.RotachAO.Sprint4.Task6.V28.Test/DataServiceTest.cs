using Tyuiu.RotachAO.Sprint4.Task6.V28.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task6.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        var word = new string[] { "����", "�����", "������", "�����", "����", "����" };
        string[] res = ds.Calculate(word);
        string[] wait = { "����", "����", "����" };
        Assert.AreEqual(wait, res);
    } 
} 
