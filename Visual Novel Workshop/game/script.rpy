# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

define b = Character("Barbie")
define k = Character("Ken")
# define bHouse = background("barbieHouse.jpg")
# define song = music("Dua Lipa Dance The Night From Barbie The Album Official Lyric Video.mp3")

# The game starts here.

label start:

    # Show a background. 
    play music "Dua Lipa Dance The Night From Barbie The Album Official Lyric Video.mp3"
    scene bg barbieHousez
    with fade

    # This shows a character sprite.

    show barbie at right
    show ken at left

    # These display lines of dialogue.

    k "Hi Barbie!"

    b "Hi Ken!"

    # This ends the game.

    return
