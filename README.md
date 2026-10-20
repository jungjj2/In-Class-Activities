# Jason Jung - in-class-activities
## Devlogs
### W1
#### Activity 1
Hello World!

When the camera is moved off the Cat GameObject, the camera stopped following the cat as there is
no longer a parent-child relationship where the Cat GameObject was parenting the camera GameObject child.

https://jungjj2.itch.io/w1-in-class-activity

### W2
### Devlog Prompt
1. The r, g, b variables use floats instead of integers, bools, or strings as they are numbers with decimals. Integers are numbers without decimals so the rgb varibles can't be integers. Bools are not numbers at all so they can't be those, and strings can contain the string values of the float numbers, but they can't be used for math operations so the rgb variables can't be strings.
2. The _bounce variable is an int as it is a whole number with no decimals. It is not a float as floats have decimals and having 3.5 bounces doesn't make sense. It is not a bool as bools aren't numbers. It is not a string as even though it can contain the string values, it can't have any math operations performed on it.
3. I got a syntax error after running which told me that the line of code was missing a semi-colon.

### W3
Activity 1 (Table 11):
1. The input parameters would be float for the the player's current friendship level and boolean for the flag that tells whether or not the player knows the character's secret because it can only be true or false. The output parameter is a string for the value of the character's text response to a player's dialogue choice.
2. The input parameter would be float for sanity level and the output parameter would be void because it doesn't output or return anything.
3. The input parameter would be float for the timing for hitting the key to match the beat and the output parameter would be bool as it will be true or false whether the player accurately hit the beat or not.

Activity 2 (Table 11):
1. The classes are like a blueprint for a building while the components are the different types of buildings. The member variables are the different things you can change about the building like the color of the building and the different objects inside of the building like furniture. Methods are like the different rooms of the building as each room serves a different purpose and can do different things like how the kitchen has a stove to cook food and the bedroom has beds to sleep in.

Devlog Question:
1. I think the ball gets brighter because the color value is being multiplied by the color multiplier which is based on how fast it is going so when the ball bounces a lot, the ball gets faster till it passes the speed threshold which increases the color multiplier which makes the ball brighter and brighter.

### W4
Table 11:
1. The solution I came up with for the collider activity was to add a rigid body to the cat and soccer ball and IsTrigger was turned on in the Goal object.
2. It did not work correctly the first time as some of the objects fell through the ground which I fixed by removing the wrong rigid bodies on objects and unchecking the wrong IsTrigger on some of the object colliders.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
