extends CharacterBody2D

#Variables
const SPEED = 300.0
const JUMP_VELOCITY = -400.0
var POINTS = 0.0
var gravity = 20

#Animation variables
@onready var animatedPlayer = $AnimationPlayer
@onready var sprite = $Sprite2D

#Hitbox variable
@onready var hitbox = $Area2D/CollisionShape2D

@export var attacking = false

func _process(delta):
	if Input.is_action_just_pressed("attack"):
		attack()
	else:
		pass

func _physics_process(delta):
	if !is_on_floor():
		velocity.y += gravity
		if velocity.y > 1000:
			velocity.y = 1000
			
	if Input.is_action_just_pressed("jump"):
		velocity.y = JUMP_VELOCITY 
		
	var horizontal_direction = Input.get_axis("left", "right")
	
	velocity.x = SPEED * horizontal_direction
	
	if horizontal_direction != 0:
		sprite.flip_h = (horizontal_direction == -1)
		
	
	move_and_slide()
	
	update_animations(horizontal_direction)
	

func update_animations(horizontal_direction):
	if !attacking:
		if is_on_floor():
			if horizontal_direction == 0:
				animatedPlayer.play("idle")
			else:
				animatedPlayer.play("run")
		else:
			if velocity.y < 0:
				animatedPlayer.play("jump")
			elif velocity.y > 0:
				animatedPlayer.play("fall")


func _on_rigid_body_2d_body_entered(body):
	if body.is_in_group("hit"):
		body.take_damage(10)
	else:
		pass# Replace with function body.
		
func attack():
	attacking = true
	hitbox.disabled = false
	animatedPlayer.play("attack")
	if(animatedPlayer.animation_finished):
		hitbox.disabled = true
