# Reilly_Zink_3401week1
 Game Development 1 lesson
 
3401 Info Sheet - Week 1 (01/15)
- Unity windows can be moved around/docked/resized
- More windows are accessible through the Windows menu
- Unity projects are divided into scenes
- Scenes can be thought of as different “levels”
- Some games (many mobile games) only have 1 scene
- The scene window shows you your physical scene layout
- You can navigate around the scene window with mouse/keyboard controls
- The hierarchy window shows you a text list of all the gameObjects in your scene
- The project window is a “palette” of all of the available assets that can be added to your scene
- An “asset” in this case means a file, such as a 3d model, a texture, an audio file, a C# script file,
etc.
- The game window is a live view of what your game currently looks like
- The inspector window shows you more details about the object you have currently selected
- The console window displays a running log of informational/warning/error messages
- Scenes are comprised of a collection of gameObjects
- GameObjects are comprised of a series of components
- Components are individual “building blocks”, each one in charge of a specific piece of
functionality
- Components can be added to/removed from gameObjects via the Component menu
- Unity has many built-in, pre-made components that work out of the box for things like rendering
objects, simulating physics, playing audio, etc.
- You can create your own components with custom functionality by creating a C# Script and
attaching it to a gameObject
- Every gameObject has a Transform component
- The transform component defines that object’s position, scale, and rotation in 3D space
- Transform components cannot be removed from gameObjects; every GO must have one
- GameObjects can be parented to one another by dragging and dropping one GO onto another in the
hierarchy window; the dragged GO will become a child of the GO it was dropped onto
- Child gameObjects use local space to define their position/scale/rotation; this means that their P/
S/R is relative to their parent’s P/S/R. If the parent object is moved 5 units to the left, the child
object will also be moved
- GameObjects that are not children of other gameObjects are known as root objects
- GameObject stacks can be infinitely deep
- New gameObjects can be created by right-clicking in the hierarchy and selecting “Create Empty”
- Selected gameObjects can be duplicated by pressing CMD/CTRL + D
- GameObjects that are used for data/non-rendered entities can still be made visible in the scene view
by giving them a gizmo
- Gizmos are only visible in the editor and will not appear in builds or the game window
- Assets can be imported into your project by dragging and dropping them into the project window, or
through the Assets menu
- Unity also allows you to directly create certain types of assets in the editor through the assets menu
