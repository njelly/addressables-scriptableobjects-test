# addressables-scriptableobjects-test

*Note: [the ScriptableEvents package I'm using is available here](https://github.com/chark/scriptable-events), however this problem has to do with the Unity engine itself, and will affect any project using both Addressables and ScriptableObjects.*

### Here's the problem...

If you're like me, you probably [read this article](https://blog.unity.com/engine-platform/6-ways-scriptableobjects-can-benefit-your-team-and-your-code) or [watched this Unite talk](https://youtu.be/raQ3iHhE_Kk) on architecting your Unity project using ScriptableObjects, and got excited about how you might use the patterns in your own project. You also like the idea of using [Addressables](https://docs.unity3d.com/Manual/com.unity.addressables.html) to control your game's memory footprint. However, as you develop, you will notice ScriptableObjects loaded via Addressables behave differently on a build than they do in the editor. This can be very discouraging, as it was for me. If you do not understand the nuance from the start, you might waste days of work before finally making a build and see that none of those ScriptableObjects you were so excited about are working!

Lesson learned: *test your project on your target platform early and often!*

### What's the solution?

[Here is a good Unity forum thread on exactly this issue that discusses a few different workarounds.](https://forum.unity.com/threads/scriptableobject-references-in-addressables.777155/)

In this project I have attempted to demonstrate one of those workarounds. I feel this solution remains true to goal of ScriptableObjects (an alternative to Singletons, highly decoupled logic, obvious and designer-friendly location of the game's state and data) while retaining the usefulness of Addressables (finer control over memory, more flexibility with Scenes in relation to memory). 

Running this project in Unity, you will notice spawning cubes via AssetReference will increment the count in the editor, but not on a build. Spawning via direct prefab reference will work regardless. The way I've set this up is the first scene is a mandatory built-in Loader scene which prompts the user to load the next scene, which is either addressable or a built-in. Built-in scenes will not work as expected, and this is not fixable. However, the addressable scene will work ***if and only if*** the ScriptableObjects in that scene ***are also addressable***. 

In the built-in scene, two instances of the ScriptableObject exist: one in the scene itself and the other with the assets loaded via Addressables. In the addressable scene, because the scene, the prefabs, *and* the ScriptableObject are loaded along side each other, there is just one instance of the ScriptableObject and all references point to that instance!

## In Editor (expected behavior):
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/024a84d4-5a9e-4049-b9a3-8a23fac503e6

## On Build (built-in scene, unexpected behavior):
https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/a97e04cb-9f02-419e-b1e4-4ab2e4928382

## On Build (addressable scene, partially fixed!)
The red counter references a ScriptableObject that is marked as addressable, the orange counter does not. The orange counter and the addressable prefab have separate instances of the ScriptableObject! The red counter's setup therefore demonstrates a viable workaround for using ScriptableObjects and Addressables.

https://github.com/njelly/addressables-scriptableobjects-test/assets/8916588/c5eda300-ef7e-4da3-86a9-fd2851ad1a4a

