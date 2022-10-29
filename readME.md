# How it is work

While checking the image (map diagram), the algorithm checks if there is a road pixel in the diagram, it checks where there is a continuation of the road or its end nearby

<br />

In the scheme, you need to specify the code that is built clockwise.
For example: <br />
12 –> Road from top to right <br/>
1234 –> Expensive in all directions

<br />

``` csharp
  | 1 |            | ○ |  
––|–––|––        ––|–––|––
4 | x | 2   ->     | ○ | ○
––|–––|––        ––|–––|––
  | 3 |            |   |   
```

<br />
<br />

# What should be done for this?
Sprites of roads, for example, create a file of road parts, write their code ( names ) there.<br />
Add a color and add the Generator.cs code to the object

<br />
<br />

``` csharp
/*
 __   __   __         ______     _____     __    __     ______     ______     __  __     ______    
/\ \ /  / /\ \       /\  __ \   /\  __-.  /\ "-./  \   /\  __ \   /\  ___\   /\ \/ /    /\  __ \   
\ \ \' /  \ \ \____  \ \  __ \  \ \ \/\ \ \ \ \-./\ \  \ \  __ \  \ \___  \  \ \  _"-.  \ \  __ \  
 \ \__/    \ \_____\  \ \_\ \_\  \ \____-  \ \_\ \ \_\  \ \_\ \_\  \/\_____\  \ \_\ \_\  \ \_\ \_\ 
  \/_/      \/_____/   \/_/\/_/   \/____/   \/_/  \/_/   \/_/\/_/   \/_____/   \/_/\/_/   \/_/\/_/ 
                                                                                                   
*/
```
