# Hello Cloud Run - .NET Core Edition

Silly little demo to show Cloud Run scaling and help optimise it.

## The App

It listens on two interfaces:

1. `/` and `/hello` - returns an array of `hello cloud run`
2. `/hello/{x}` - returns an array of `hello {x}` where `{x}` is abitrary text

All code is defined in [Controllers/HomeController.cs](Controllers/HomeController.cs)

