# Abstract
I have always been mildly irritated by how many .net project I need to create in my standard workflow.
Usually I start with an idea for a library, I want to test it with a simple executable, write some tests for it and benchmark some key scenarios. So I end up with at least four project to manage.

Sure, I can find ways to automatically generate those projects, but I have always been weary of codegen to solve complexity issues. It always ends up coming back to bite you. For those of you as old as I am, think [MFC](https://en.wikipedia.org/wiki/Microsoft_Foundation_Class_Library) ...

So what is my ideal world then? Well, let's try this:

1. One single project for the library and related artifacts (i.e. test, benchmarks, etc...).
2. Distinguish the library code from the test code from the benchmark code by some convention (i.e. name scheme).
3. Generate each artifact (i.e. library, tests, benchmarks, executable) by passing different options to `dotnet build` and `dotnet run`.
4. Create a new project by using the standard `dotnet new` syntax.
5. Have intellisense working normally in each file for my chosen editor (VSCode).

# Disclaimer
What follows, despite working fine, is not the standard way .net tools are used. It is not in the 'golden path'. That is problematic
for production usage as:

1. It might not work in your particular configuration.
2. It might not work with other tools that rely on the presence of multiple projects (i.e. code coverage? ...).
3. It might work now in all scenarios but get broken in the future as you update to a new framework, sdk, editor.
4. It might expose bugs in the tools, now or later, which aren't going to be fixed as you are not using the tools as intended.
5. It might upset your coworkers that