# Interls Visible TypeScript

C# has an `internal` modifier and an `InternalsVisibleTo` assembly property which can expose internals to other assemblies.
This is quite useful for allowing tests to mock out dependencies without having to expose that extra configuration and complexity to consumers.

There is a  C# project in the `/csharp` folder which demonstrates the situation above.
In the TypeScript `/ts` project there is a demonstration of technique using classes which are not exposed with library but are still available to tests to simulate behavior of `InternalsVisibleTo`