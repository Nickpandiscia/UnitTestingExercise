using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project: -DONE

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project - DONE
        // and add your reference to the UnitTestingExercise project -DONE



        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer -DONE
        //For Example:
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method -DONE


        // Step 4: 
        // Create a Subtract method that accepts 2 integers -DONE
        // Keep track of which number is getting passed as minuend and subtrahend -DONE
        public int Subtract(int sub1, int sub2)
        {
            return sub1 - sub2;
        }


        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method -DONE


        // Step 6: 
        // Create a Multiply method that passes 2 integers -DONE
        public int Multiply(int mul1, int mul2)
        {
            return mul1 * mul2;
        }


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method -DONE


        // Step 8: 
        // Create a Divide method that passes 2 integers -DONE
        public int Divide(int div1, int div2)
        {
            return div1 / div2;
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method -DONE


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
