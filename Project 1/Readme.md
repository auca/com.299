Project #1
==========

## Pong

![Pong](http://i.imgur.com/Uj8TL2E.jpg)

Pong is a classic arcade video game. It was one of the first games that managed
to reach mainstream popularity. It was released in 1972 and was developed by
Allan Alcorn, an engineer from Atari. It was a training exercise at the company.
The idea of the game came from Nolan Bushnell, the co-founder of Atari, though
he was inspired by a similar ping pong game included with Magnavox Odyssey, one
of the first video game consoles (released around that time).

The goal is to defeat an opponent in a table-tennis game by earning a higher
score. The player can move a paddle up or down across the left side of the
screen. The other paddle can be controlled by a computer or another player.
Both sides compete to earn eleven points. Points are earned when one fails to
return the ball to the opponent.

The first task of the project is to recreate the Pong game in the Unity game
engine. The second task is to modify the Pong gameplay mechanics considerably or
to reuse it to create a different game such as Breakout or Pinball.

### Practice #1

![Practice 1](http://i.imgur.com/TNTxs2s.png)

Create a game field with a ball surrounded by walls. Use default plane and cube
meshes from Unity for the objects. Allow to apply forces to the ball with the
horizontal and vertical input axes of the engine. The ball should leave a trail
behind it. The ball should bounce from the walls and slide on the plane without
losing its speed due to friction or air drag.

### Practice #2

![Practice 2](http://i.imgur.com/ecQEFjL.png)

Remove two walls on opposite sides and replace them with paddles. Allow the
player to control both paddles with horizontal or vertical input axes. Allow
precise controls for paddles to change direction by minimizing the momentum of
their movement. Push the ball at an angle from 20 to 45 degrees forward. Reflect
the ball from walls. Reflect the ball from paddles. Depending on the side of the
paddle that was hit, add a certain amount of force toward that side to the ball
to give the player additional control. Respawn the ball when it leaves the
field, add points, and update the score on the screen.

### Practice #3

![Practice 3](http://i.imgur.com/nLfABtV.png)

Improve the aesthetics of the game by adding a texture with a dashed line to
divide the field between players. Find a public domain font similar in the style
to pixelated fonts used in the original game and use it to display score labels.
Use BFXR to generate sounds or find public domain sound effects. Play them for
different in-game events such as collisions of the ball with walls and paddles.
Try to randomize the initial direction of the ball on respawn. Use natural
angles and try to move the ball in the opposite direction from the side that
lost the ball the last time. Ensure that the ball cannot tunnel through walls or
paddles.

### Task #1

![Task 1, Unity Project](http://i.imgur.com/NHGpEPu.png)
![Task 1, Game](http://i.imgur.com/CraJG3p.png)

Ensure the following requirement are met.

* Allow to control paddles by moving the mouse up or down.
* Add a simple AI to control the second paddle to follow the ball.
* Allow matches with the AI. The match ends when someone gets 11 points first.
Matches should be time limited. The player with the highest score wins after the
time limit. A message is displayed to congratulate the player at the end of the
match and a new match is automatically started after a short pause.
* Polish your game visually and in terms of gameplay. Play test your game on
your own and with other students. Add icons and a banner to the launcher on
Windows, macOS, or Linux.

### Task #2

![Task 2, Breakout](http://i.imgur.com/QT7ZbCp.png)

Reuse the Pong gameplay mechanics to create a different game. You can easily
modify your code to create games such as Breakout or Pinball. You can also
change the rules of the Pong game to get something new. You can add players on
all four sides, you can position more than four players around a circle. You can
even try reflecting ball in 3 dimensions instead of two. As usual, polish your
game's visuals and gameplay. Play test it alone and with other students. Add
icons and a banner to the launcher on Windows, macOS, or Linux. Make sure that
the game looks and works like a real product ready for release.

### Grading

* +20 points for Practice #1
* +20 points for Practice #2
* +10 points for Practice #3
* +20 points for Task #1
* +26 points for Task #2

You game will be judged subjectively (as on a real market) by an independent
third-party user without any experiense in game development or software
engineering.

* +1 if the user likes how your game looks
* +3 if he likes to play your game

The total number of points will then be converted into a grade.

* 95%–100%: A
* 90%–94%: A-
* 85%–89%: B+
* 80%–84%: B
* 75%–79%: B-
* 70%–74%: C+
* 65%–69%: C
* 60%–64%: C-
* 55%–59%: D+
* 50%–54%: D
* 45%–49%: D-
* Less than 40%: F

### Deadlines

You will have three weeks from the announcement date to finish your work.

### Submission

#### Option #1

Pack you project directory and send it to the instructor.

#### Option #2

Send a link to a shared directory or an archive file with your project on a file
sharing service like Google Drive or Dropbox.

#### Option #3

Send a link to a publicly available Git repository with your project. Try to use
Git to store the development history of your project, not just to submit your
work. Students with properly maintained repositories will get five extra points
to their grades.

* Use a proper [.gitignore](https://github.com/github/gitignore/blob/master/Unity.gitignore)
file.
* [Configure](http://www.studica.com/blog/how-to-setup-github-with-unity-step-by-step-instructions)
Unity to work with Git
