using Tyuiu.RotachAO.Sprint4.Task5.V16.Lib; 
 
namespace Tyuiu.RotachAO.Sprint4.Task5.V16.Test; 
 
[TestClass] 
public class DataServiceTest 
{ 
   [TestMethod] 
   public void ValidExpression()  
   {
        DataService ds = new DataService();
        int[,] data = new int[,] { { 5, -2 }, { -3, 4 } };
        int[,] res = ds.Calculate(data);
        int[,] x = new int[,] { { 1, -2 }, { -3, 1 } };
        CollectionAssert.AreEqual(x, res);
    } 
} 
