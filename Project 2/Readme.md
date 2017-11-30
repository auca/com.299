Project #2
==========

## Open Project

### Requirements

The second project on this courses is an open-topic game. It is up to you to
select a game genre, decide what kind of gameplay mechanics to use, and how the
controls should work.

You game must include the following

* A menu (+10 points)

Include a menu in your game with a stylized panel and buttons to allow players
at least to start/restart/continue the game, read credits, exit from the app.
Players should always be able to open the menu by pressing the `Escape` button
or a menu button on mobile.

* At least three different levels (+40 points)

Use `SceneManager.LoadScene` to move from one level to another.

The first level should be a tutorial to briefly explain mechanics and controls
of the game. You can show a number of text messages to give information about
key elements of the game one by one. Then, you can ask the user to try things
out on his own. At the end of the level, you should give the player his first
challenge by clashing his character with an enemy unit or units.

The next level (or all consequent levels excluding the last one) should include
several enemy types with different state machines for their AI (e.g., one enemy
will follow the player character in proximity, another will guard some object
and shoot everything close to it).

The final level should be a boss battle with one or several enemies with a
state-machine for their AI above any other enemy characters in the game.

For now characters and enemies can be simple geometric primitives with different
materials.

* Level geometry and models (+15 points)

The level geometry and level props such as trees or boulders should be created
in a third-party 3-D modeling application like Blender. All models should have
properly unwrapped UV coordinates. The models should be textured in any
graphical application like GIMP. Try using a stylized cartoon/pixelated/cel
style to minimize the effort of asset creation.

* Navigation Mesh (+15 points)

The level should include a navigation mesh and enemies should use it to move
around. The player character may also use it for its movement.

* Particle Effects (+10 points)

Use particle effects in Unity at least once. You may add them to show
projectiles or explosions.

* Music (+5 points)

Create (we don't know all your talents, right), or generate, or try to find
public domain music for your game. it is important to honor copyright and
ownership rules. Be carefully and ensure the license is included with the piece
of work. Ensure it permits free non-commercial use.

For example, you can use projects that try to find, catalogue, or even record
public domain classical music.

<https://musopen.org>
<https://www.welltemperedclavier.org>
<http://www.opengoldbergvariations.org>

Or you can use a project that uses deep learning to procedurally generate public
domain music of different genres.

<https://www.jukedeck.com>

* Sound FX (+5 points)

Create, or generate through Bfxr, or find public domain sound effects for you
game. Follow the same rules from the previous requirement honoring rights and
copyright of the authors.

You may find the following collection of royalty free or public domain music
useful

<https://gamesounds.xyz>

* Rigged Animated Models (extra +10 points)

Replace you simple prototype 3-D objects with rigged and animated game
characters. You must create the models, their rigs, and record animation
manually in Blender to get the points.

* Multiplayer (extra +20 points)

Add multiplayer functionality to your game. Use the high-level Unity's
networking API ([HLAPI](https://docs.unity3d.com/Manual/UNetUsingHLAPI.html) to
synchronize the state of objects between clients and to send messages between
instances to drive the gameplay.

As usual, polish your game's visuals and gameplay. Play test it alone and with
other students. Add icons and a banner to the launcher on Windows, macOS, or
Linux. Make sure that the game looks and works like a real product ready for
release.

### Grading

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

* Use a proper [.gitignore](https://github.com/github/gitignore/blob/master/Unity.gitignore) file.
* [Configure](http://www.studica.com/blog/how-to-setup-github-with-unity-step-by-step-instructions) Unity to work with Git

