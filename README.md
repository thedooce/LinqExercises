# LINQ Exercises

A learning environment for the 40 C# LINQ exercises from
[pynative.com/csharp-linq-exercises](https://pynative.com/csharp-linq-exercises/).

## Structure

- `src/Exercises/` — one file per exercise (`Exercise01.cs` ... `Exercise40.cs`). Each has the
  problem statement as an XML doc comment, a method signature, and a `TODO` + `throw new
  NotImplementedException()` for you to replace with a LINQ one-liner (or a few lines).
  Shared data types (`User`, `Product`, `Employee`, `Book`, etc.) live in `Models.cs`.
- `src/Exercises.Tests/` — one xUnit test file per exercise, asserting against the exact
  expected output from the source article. These are your feedback loop.

## How to work through it

1. Open `src/Exercises/Exercise01.cs` and replace the `throw new NotImplementedException();`
   with a LINQ expression that solves the problem described in the comment above the method.
2. Run just that exercise's test:

   ```bash
   dotnet test --filter "FullyQualifiedName~Exercise01Tests"
   ```

3. When it passes, move to `Exercise02.cs`, and so on through `Exercise40.cs`.
4. Run everything at any time with:

   ```bash
   dotnet test
   ```

Exercises are ordered roughly by difficulty: filtering/sorting basics (1–11), projections and
flattening (12–20), aggregation (21–30), then grouping/joins/set operations (31–40).

## Notes on a few exercises

- **Exercise 13** (anonymous types) returns `IEnumerable<dynamic>` so you can genuinely use
  `select new { ... }` inside the method.
- **Exercise 31** (group by age) returns `IEnumerable<IGrouping<int, Person>>` directly from
  `GroupBy` — no need to convert it to anything else.
- **Exercises 33/34** (joins) use dedicated models (`Student`/`Course`,
  `EmployeeRecord`/`DepartmentInfo`) to keep the join keys simple foreign-key ints.
