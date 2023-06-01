# addressables-scriptableobjects-test

*Note: [the ScriptableEvents package I'm using is available here](https://github.com/chark/scriptable-events), however this problem has to do with the Unity engine itself, and will affect any project using both Addressables and ScriptableObjects.*

### Here's the problem...

If you're like me, you probably [read this article](https://blog.unity.com/engine-platform/6-ways-scriptableobjects-can-benefit-your-team-and-your-code) or [watched this Unite talk](https://youtu.be/raQ3iHhE_Kk) on architecting your Unity project using ScriptableObjects. However there are some unintuitive ways ScriptableObjects behave on a build vs the editor, as this project sets out to demonstrate as simply and clearly as possible. In this demonstration, spawning cubes via AssetReference will increment the count in the editor, but not on a build. Spawning via direct prefab reference will work regardless. If you do not understand this nuance from the start, you might waste days of work before finally making a build and seeing that none of those ScriptableObjects you were so excited about are working!

Lesson learned: *test your project on your target platform early and often!*

### What's the solution?

[Here is a good Unity forum thread on exactly this issue that discusses possible workarounds](https://forum.unity.com/threads/scriptableobject-references-in-addressables.777155/).

In this project I have attempted to demonstrate a viable workaround. The first scene in this project is a mandatory built-in Loader scene which prompts the user to load the next scene, which is either an addressable scene or a built-in scene. Built-in scenes *will not* work as expected, and this is not fixable. However, the addressable scene ***will work*** as long as the scriptable objects in that scene are ***also addressable***.

## In Editor (expected behavior):
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/024a84d4-5a9e-4049-b9a3-8a23fac503e6

## On Build (built-in scene, unexpected behavior):
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/a97e04cb-9f02-419e-b1e4-4ab2e4928382
