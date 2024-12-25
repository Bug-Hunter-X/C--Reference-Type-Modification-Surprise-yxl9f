# C# Reference Type Modification Surprise

This repository demonstrates a subtle but common issue in C# involving reference types and unexpected behavior when modifying objects.

The `bug.cs` file contains code that showcases the problem: modifying one variable unexpectedly affects another. The `bugSolution.cs` provides a solution using cloning or creating a new object to avoid unintended side effects.

This example highlights the importance of understanding how reference types work in C# to prevent bugs related to unintended object sharing and modification.