extends CharacterBody2D


const SPEED = 300.0
const JUMP_VELOCITY = -400.0

# Get the gravity from the project settings to be synced with RigidBody nodes.
var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")

#Animation variables
@onready var animated_sprite = $AnimatedSprite2D

#Hitbox variable
@onready var hitbox = $Area2D/CollisionShape2D


func _physics_process(delta):
	# Add the gravity.
	if not is_on_floor():
		velocity.y += gravity * delta
		
		if(velocity.y < 0):
			animated_sprite.animation = "jump"
		else:
			animated_sprite.animation = "fall"
	else:
		if(velocity.x == 0):
			animated_sprite.animation = "idle"
		else:
			animated_sprite.animation = "run"
			
	# Handle Jump.
	if Input.is_action_just_pressed("jump") and is_on_floor():
		velocity.y = JUMP_VELOCITY

	# Get the input direction and handle the movement/deceleration.
	# As good practice, you should replace UI actions with custom gameplay actions.
	var direction = Input.get_axis("left", "right")
	if direction:
		velocity.x = direction * SPEED
		if(velocity.x < 0):
			animated_sprite.flip_h = true
		else:
			animated_sprite.flip_h = false
	else:
		velocity.x = move_toward(velocity.x, 0, SPEED)
		
	#Handle Attacks
	if Input.is_action_just_pressed("attack"):
		hitbox.disabled = false
		animated_sprite.play("attack")
		await get_tree().create_timer(0.3).timeout
	else:
		hitbox.disabled = true
	move_and_slide()
	


func _on_area_2d_body_entered(body):
	if body.is_in_group("hit"):
		body.take_damage(10) # Replace with function body.
# Replace with function body.


 # Replace with function body.


