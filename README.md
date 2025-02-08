# Uninitialized Property in Calculation

This code demonstrates a common error in C# where a property is used in a calculation before it has been explicitly assigned a value.  The default value of the property is used instead, which could result in unexpected behavior and incorrect results.

The `Bug.cs` file shows the erroneous code. The `BugSolution.cs` provides a corrected version with proper initialization.  This example highlights the importance of initializing properties before using them in calculations to avoid unexpected outcomes and ensure program correctness.