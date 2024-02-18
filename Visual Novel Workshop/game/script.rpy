# The script of the game goes in this file.

# Declare characters used by this game. The color argument colorizes the
# name of the character.

define b = Character("Barbie")
define k = Character("Ken")
image bg house = "images/Barbie House.jpg"
# define bHouse = background("barbieHouse.jpg")
# define song = music("Dua Lipa Dance The Night From Barbie The Album Official Lyric Video.mp3")

# The game starts here.

label start:

    # Show a background. 
    play music "Dua Lipa Dance The Night From Barbie The Album Official Lyric Video.mp3"
    scene house
    with fade

    # This shows a character sprite.

    show barbie at right
    show ken at left

    # These display lines of dialogue.

    k "Hi Barbie!"

    b "Hi Ken!"

    k "What plans do you have for today?"

    b "I forgot something at home, so I have to go grab that. Then I was gonna go to the beach"

    b "What about you?"

    k "I'm going to the beach! Can I come with you?"

    menu:
        "Yeah!":
            jump yes

        "No thanks, I'm meeting President Barbie":

            jump no

    label yes:

        k "Yes! You're so cool Barbie"

        return

    label no:

        k "Oh...okay...see you later Barbie"

        b "See ya!"

        return

    

    
