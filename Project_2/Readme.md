Project #2
==========

## Open Project

### Requirements

The second project on this courses is an open-topic game. It is up to you to
select a game genre, decide what kind of gameplay mechanics to use, and how the
controls should work. As a suggestion, we recommend you to take a look at a
game [Fall Guys](https://store.steampowered.com/app/1097150/Fall_Guys_Ultimate_Knockout)
that became popular this year on most major game platforms 

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

The consiquent levels (or all consequent levels excluding the last one) should
include several enemy types with different state machines for their AI (e.g.,
one enemy will follow the player character in proximity, another will guard some
object and shoot everything close to it).

For now characters and enemies can be simple geometric primitives with different
materials.

* Level geometry and models (+15 points)

The level geometry and level props such as trees or boulders should be created
in a third-party 3-D modeling application like Blender. All models should have
properly unwrapped UV coordinates. The models should be textured in any
graphical application like GIMP. Try using a stylized cartoon/pixelated/cel
style to minimize the effort of asset creation.

* Navigation Mesh (+15 points)

The levels should include a navigation mesh and enemies should use it to move
around. The player character may also use it for its movement.

* Particle Effects (+10 points)

Use particle effects in Unity at least once. You may add them to show
projectiles or explosions.

* Music (+2.5 points)

Create (we don't know all your talents, right), or generate, or try to find
public domain music for your game. it is important to honor copyright and
ownership rules. Be carefully and ensure the license is included with the piece
of work. Ensure it permits free non-commercial use.

For example, you can use projects that try to find, catalogue, or even record
public domain classical music.

<https://musopen.org>
<https://www.welltemperedclavier.org>
<http://www.opengoldbergvariations.org>

* Sound FX (+2.5 points)

Create, or generate through Bfxr, or find public domain sound effects for you
game. Follow the same rules from the previous requirement honoring rights and
copyright of the authors.

You may find the following collection of royalty free or public domain music
useful

<https://gamesounds.xyz>

* Rigged Animated Models (extra +10 points)

Replace you simple prototype 3-D objects with rigged and animated game
characters. You must create the models, their rigs, and record animation in any
tool you want. Adobe [mixamo](https://www.mixamo.com) can simplify the task
considerably.

As usual, polish your game's visuals and gameplay. Play test it alone and with
other students. Add icons and a banner to the launcher on Windows, macOS, or
Linux. Make sure that the game looks and works like a real product ready for
release.

### Grading

* +5 points for menu
* +20 points for three different levels
* +10 points for navigation mesh with basic AI
* +5 points for particle effects
* +5 points for simple level geometry and models
* +5 points for music and sound FX
* +10 bonus points for rigged animated models

### Deadlines

You will have time before the Final Exam to finish your work.
