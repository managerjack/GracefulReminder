# GratefulReminder

(Click "Assets" --> "Scripts" to navigate towards the scripts used in the game)

## Installation



## Script terms & definitions

**using System.Collections**: Contains interfaces and classes that define various collections of objects, such as lists, queues, bit arrays, hash tables and dictionaries.

**using System.Collections.Generic**: Contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

**using UnityEngine**: It imports the "UnityEngine" namespace, which is a library of classes and data types that represents it. So if I want to log something to the console, I can write 'Debug.log("Hello user")' because I'm using the "UnityEngine" namespace. Without it, it would be like 'UnityEngine.Debug.log("Hello user")'.

**MonoBehaviour**: MonoBehaviour is the base class from which every Unity script derives. When you use C#, you must explicitly derive from MonoBehaviour.

**void Start()**: Start is called on the frame when a script is enabled just before any of the Update methods are called the first time.

**void Update()**: Update is called every frame, if the MonoBehaviour is enabled.

**BoxCollider2D**: Collider for 2D physics representing an axis-aligned rectangle. It's a physical component in the game scene used for physics simulation and/or detection.

**gameObject**: A gameobject in lowercase letters is a reference to the gameobject that a component is attached to.

**Collider2D.offset**: (The BoxCollider 2D is a type of Collider2D) The local offset of the collider geometry. This offset can be used to shift the local origin of any 2D collider geometry.

**Vector2**: Representation of 2D vectors and points.

**Vector3**: Representation of 3D vectors and points.

**Camera.main.orthographicSize**: Camera's half-size when in orthographic mode. The orthographicSize property defines the viewing volume of an orthographic Camera.

**Screen.width**: The current width of the screen window in pixels.

**Screen.height**: The current height of the screen window in pixels.

