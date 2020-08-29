# Unity3D-Helix-Jump-Example

This project about Helix Jump Game. Unity 2019.3.5f1 was used. In the project, the control will be with mouse and I use it GetAxis in "Mouse X".

I made just one scene to try myself. If you want, you can develop it.

This is the first building to see when you open the project.
![MainScreen](https://user-images.githubusercontent.com/59045890/91636035-2afabc00-ea06-11ea-9749-0e02e5fdf1f0.png)

Also the hierarchy and Project part are as under images.

![hierarchy](https://user-images.githubusercontent.com/59045890/91636161-14a13000-ea07-11ea-90f4-9e1b0bc27f65.png)
![project](https://user-images.githubusercontent.com/59045890/91636197-73ff4000-ea07-11ea-8054-6e79d4c47118.png)

When you start the program, all slices will be created and there will be yellow slices called enemies and black floors called floors.
![Instantiate](https://user-images.githubusercontent.com/59045890/91636476-8aa69680-ea09-11ea-9b03-705a353b8e5c.png)

If the ball touch the yellow slice, it will explode and I wanted to use Particular System for explosion. (to just learn)
![boom](https://user-images.githubusercontent.com/59045890/91636477-8d08f080-ea09-11ea-82b3-189e7dc05d05.png)

the rotation need to be Y axis but GetAxis get X axis for turning.
![cyclinder turn](https://user-images.githubusercontent.com/59045890/91636854-8cbe2480-ea0c-11ea-9ddc-4b06ee6e226b.png)

Helix slices will be created in this part.
![Increase](https://user-images.githubusercontent.com/59045890/91637002-ad3aae80-ea0d-11ea-9c8e-abe232f0fc9a.png)

What happeden when the ball hits the ground?
![OnCollision](https://user-images.githubusercontent.com/59045890/91637303-3a7f0280-ea10-11ea-9d5b-e662fc4315fb.png)
