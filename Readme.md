### Pokey Playthings

This is just a collection of fsharp experiments that are too small to make into their
own projects. (Well, there's also the fact that I have no idea how to create an fsharp
projects yet)

I'm trying to do things on mono with emacs. I've installed mono 3 on osx and the emacs
fsharp-mode. This lets me open fsharpi, the interpreter, in emacs. That lets me send
things from the fsharp buffer to the repl and evaluate things there. That's step 1 and
it works pretty well.

#Things I have no idea how to do yet.

* Set up an fsharp project. Every tutorial I see uses visual studio. fsharp-mode
  supposedly has a way to do all the great intellisense things that visual studio
  does inside emacs which sounds awesome to me. It needs an fsharp project file
  which as far as I can tell is just some gross xml thing that's generated by vs.
  I've heard of FAKE and wonder if that's just a way to write build scripts or if
  that has to do with project fileness too.
* Manage dependencies. I think nuget is what's suppossed to be used but have no idea
  how to do so, how to manage them on a project by project basis and how to get them
  installed in a place that I can use them.

The language impresses me, the mono tooling just seems to be crap....