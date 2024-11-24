using Tyuiu.RotachAO.Sprint4.Task1.V28.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task1.V28.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();

        int[] numsArray = { 2, 4, 4, 5, 3, 4, 4, 6, 2, 4, 5, 5, 4, 4 };

        int res = ds.Calculate(numsArray);
        int wait = 393216;
        Assert.AreEqual(wait, res);
    } 
} 
