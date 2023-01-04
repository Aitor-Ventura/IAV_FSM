_Modifica el proyecto de Línea de Visión para hacer que el NPC se controle a través de una máquina de estados. Los estados son:_

_- Patrol: implementa el método "wander". Si el jugador entra en el campo de visión del agente pasa al estado "Chase"._

_- Chase: implementa "Seek" o "Pursue" para seguir al jugador. Si el jugador está dentro de la distancia de tiro pasa al estado "Attack". Si el jugador deja de estar en el campo de visión, pasa al estado "Patrol"._

_- Attack: dispara al jugador. Si la distancia con el jugador es superior a la distancia de tiro, pasa al estado "Chase". Si la vida del NPC está por debajo de una cantidad, pasa al estado "Hide"._

_- Hide: implementa el método "Hide" o "CleverHide" y regenera la vida del NPC. Si la vida está por encima de un valor, pasa al estado "Patrol"._

---

Se desarrolló un controlador para el NPC. Se desarrolló la máquina de estados finitos incorporando los cuatro comportamientos correspondientes. Para el método "Patrol" se crearon tres waypoints diferentes entre los que el NPC caminaría. Para el método "Chase" se hace referencia a la posición del jugador y se dirige al NPC a través de su NavMesh. Para el método "Attack" se instancia un prefab de una bala con un rigidbody. Para el estado "Hide" se dirige al NPC a través del NavMesh a un waypoint.

![](/gif.gif)

A controller for the NPC was developed. The finite state machine was developed implementing the four corresponding behaviours. For the "Patrol" method, three different waypoints were created and the NPC would walk between them. For the "Chase" method the player's position is referenced and the NPC is moved using its NavMesh component. For the "Attack" method a prefab of a bulklet with a rigidbody is instantiated. For the "Hide" method the NPC is moved using its NavMesh component to a waypoint.
