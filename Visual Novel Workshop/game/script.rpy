# The script of the game goes in this file.

# Declare characters used by this game. 
define b = Character("Barbie")
define k = Character("Ken")
image bg bHouse = "images/bHouse.jpg"

# The game starts here.

label start:

    # Show a background. 
    scene bg bHouse
    play music "Dua Lipa Dance The Night From Barbie The Album Official Lyric Video.mp3"
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

    

    
