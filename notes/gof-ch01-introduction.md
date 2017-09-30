
Intro

* Good OO designs allow
    * reuse
    * flexibility
* getting those "right" often taken several iterations
* stand on shoulders; do not resolve these problem
* GOF catalogs patterns from existing systems

What is a design pattern? 

* repeated problem > core of a solution > inspiration for your solution
* "a [generalized] solution to a problem in a context"
* four parts
    * name
    * problem
    * solution
    * consequences [outcome]
* "descriptions of communicating objects and classes that are customized to solve a general design problem in a particular context"

Design patterns in Smalltalk MVC

* MVC decouples these three to enable reuse/flexibility
    * model: application object
    * view: its screen presentation
    * controller: how the UI reacts to user input
* There are patterns in there
    * The view-model relationship is an *Observer* pattern
    * Nested views are a *Composite* pattern
    * The view-controller relationship is a *Strategy* pattern

Describing design patterns

* name: the pattern's essense 
* classification: 
* intent: what does the pattern do?
* aka: other names
* motivation: the problem and its solution
* applicability: when to use it
* structure: graphical representation of its classes
* participants: responsibilities of its classes and objects
* collaborations: how the classes/objects interact
* consequences: pros/cons & what the pattern allows us to vary independently
* implementation: pitfalls, hints, techniques, subtleties
* sample code: C++/Smalltalk
* known uses: where did the GOF find it?
* related patterns: comparison to similar patterns & commonly collaborating patterns

The catalog of desing patterns

* the name and 
* the intent

Organizing the catalog

How design patterns solve design problems

How to select a desing pattern

How to use a design pattern

