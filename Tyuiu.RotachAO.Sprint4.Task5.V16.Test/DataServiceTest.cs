using Tyuiu.RotachAO.Sprint4.Task5.V16.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task5.V16.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[,] data = new int[,] { { -6, 3, 3, 0, -3 }, { -6, -6, -4, -4, 1 } };
        int[,] res = ds.Calculate(data);
        int[,] x = new int[,] { { -6, 1, 1, 0, -3 }, { -6, -6, -4, -4, 1 } };
        CollectionAssert.AreEqual(x, res);
    } 
} 
