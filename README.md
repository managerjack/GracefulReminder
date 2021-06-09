# GratefulReminder

(Click "Assets" --> "Scripts" to navigate towards the scripts used in the game)

## Installation



## Script terms & definitions

**using System.Collections**: Contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables and dictionaries.

**using System.Collections.Generic**: Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

**using UnityEngine**: It imports the "UnityEngine" namespace, which is a library of classes and data types that represents it. So if I want to log something to the console, I can write 'Debug.log("Hello user")' because I'm using the "UnityEngine" namespace. Without it, it would be like 'UnityEngine.Debug.log("Hello user")'.

**using UnityEngine.SceneManagement**: It imports the library and namespace for scene management. ex. loading a scene, restart scene etc.

**using UnityEngine.UI**: It's the namespace for using the UI library which grants access to use functionlities for UI elements, like text and images.

**MonoBehaviour**: MonoBehaviour is the base class from which every Unity script derives. When you use C#, you must explicitly derive from MonoBehaviour.

**void Awake()**: Awake is called when the script instance is being loaded.

**void Start()**: Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.

**void Update()**: Update is called every frame, if the MonoBehaviour is enabled.

**BoxCollider2D**: Collider for 2D physics representing an axis-aligned rectangle. It's a physical component in the game scene used for physics simulation and/or detection.

**gameObject**: A gameobject in lowercase letters is a reference to the gameobject that a component is attached to.

**GameObject**: A GameObject is a base class for all entities in Unity Scenes. It's a physical object visible and existent in the scene.

**Collider2D.offset**: (The BoxCollider 2D is a type of Collider2D) The local offset of the collider geometry. This offset can be used to shift the local origin of any 2D collider geometry.

**Vector2**: Representation of 2D vectors and points.

**Vector3**: Representation of 3D vectors and points.

**Camera.main.orthographicSize**: Camera's half-size when in orthographic mode. The orthographicSize property defines the viewing volume of an orthographic Camera.

**Screen.width**: The current width of the screen window in pixels.

**Screen.height**: The current height of the screen window in pixels.

**BoxCollider2D.size**: The width and height of the rectangle.

**Material**: It's a class tht exposes all properties from a material, allowing you to animate them. You can also use it to set custom shader properties that can't be accessed through the inspector.

**SpriteRenderer**: Renders a Sprite for 2D graphics.

**Material.color**: The main color of the Material.

**Color**: Representation of RGBA colors. This structure is used throughout Unity to pass colors around. Each color component is a floating point value with a range from 0 to 1.

**Color.Lerp**: Linearly interpolates between colors a and b by t.

**Cursor.visible**: Determines whether the hardware pointer is visible or not.

**Camera.main.ScreenToWorldPoint**: Transforms a point from screen space into world space, where world space is defined as the coordinate system at the very top of your game's hierarchy.

**Input.mousePosition**: The current mouse position in pixel coordinates.

**Input.GetMouseButton()**: Returns whether the given mouse button is held down (0 is left mouse button, 1 is right mouse button).

**Input.GetMouseButtonDown()**: Returns true during the frame the user pressed the given mouse button (0 is left mouse button, 1 is right mouse button).

**Object.Instantiate**: Clones the object original and returns the clone.

**Transform.SetParent**: Set the parent of the transform to itself or a different transform.

**Object.Destroy()**: Removes a GameObject, component or asset.

**void OnTriggerStay2D()**: Sent each frame where another object is within a trigger collider attached to this object (2D physics only).

**void OnTriggerEnter2D()**: Sent when another object enters a trigger collider attached to this object (2D physics only).

**void OnTriggerExit2D()**: Sent when another object leaves a trigger collider attached to this object (2D physics only).

**name.Contains()**: Checks if the name of the object contains the specified string value.

**Text**: The string value this Text displays. This is the string value of a Text component. Use this to read or edit the message displayed in Text.

**SceneManager.LoadScene()**: Loads the Scene by its name or index in Build Settings (In the build settings, there's a layout of the different scenes with their assigned indexes that uniquely identifies them).

**enabled**: It's a keyword that is used to turn a component on or off depending on the set value ('True' = component is enabled, 'False' = component is disabled).

**Button**: A standard button that can be clicked in order to trigger an event. It's a physical component in the scene that can be clicked upon and you can assign events to the button when clicking trigger happens. 

**GameObject.SetActive()**: Activates/Deactivates the GameObject, depending on the given true or false value.

**Input.anyKey**: Checks if any key or mouse button is currently held down.

**Input.GetKey()**: Returns true while the user holds down the key identified by name.

**Input.GetKeyDown()**: Returns true during the frame the user starts pressing down the key identified by name.

**KeyCode**: Representation of the different key inputs.

**Text.text**: The string value this Text displays.

**Time.timeScale**: The scale at which time passes. This can be used for slow motion effects or to speed up your application. When timeScale is 1.0, time passes as fast as real time. When timeScale is 0.5 time passes 2x slower than realtime.

**Time.deltaTime**: The interval in seconds from the last frame to the current one.

**void OnSendClicked()**: It's a click event for whenever the user clicks on the 'Send' button.

**RigidBody2D**: Rigidbody physics component for 2D sprites.

**Rigidbody2D.AddForce()**: Apply a force to the rigidbody. The force is specified as two separate components in the X and Y directions (there is no Z direction in 2D physics). The object will be accelerated by the force according to the law force = mass x acceleration - the larger the mass, the greater the force required to accelerate to a given speed.

**ForceMode2D.Impulse**: Add an instant force impulse to the rigidbody2D, using its mass.

**Random.Range**: Returns a random float within [minInclusive..maxInclusive] (range is inclusive).

**Quaternion.Euler**: Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis; applied in that order.

**Vector3.MoveTowards**: Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta.
