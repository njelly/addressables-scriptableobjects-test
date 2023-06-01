# addressables-scriptableobjects-test
If you're like me, you probably [read this article](https://blog.unity.com/engine-platform/6-ways-scriptableobjects-can-benefit-your-team-and-your-code) or [watched this Unite talk on architecting your Unity project using ScriptableObjects](https://youtu.be/raQ3iHhE_Kk). However there are some unintuitive ways ScriptableObjects behave on a build vs the editor, as this project sets out to demonstrate as simply and clearly as possible. Spawning cubes via AssetReference will increment the count in the editor, but not on a build. Spawning via direct prefab reference will work regardless. I wasted too much time coming to understand this issue so you don't have to. 

[Here is a good Unity forum thread on exactly this issue that discusses possible workarounds](https://forum.unity.com/threads/scriptableobject-references-in-addressables.777155/).

I have attempted to demonstrate a viable workaround. In this project, there are 3 scenes. The first is a mandatory built-in Loader scene which prompts the user to load the next scene, which is either an addressable scene or a built-in scene. Built-in scenes *will not* work as with instantiated addressable assets containing references to scriptable objects. However, the addressable scene ***will work*** so long as the scriptable objects in that scene are ***also addressable***.

## On Build:
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/a97e04cb-9f02-419e-b1e4-4ab2e4928382

## In Editor:
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/024a84d4-5a9e-4049-b9a3-8a23fac503e6
