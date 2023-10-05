extends RigidBody2D

var health = 30
@onready var enemy_sprite = $AnimatedSprite2D

func take_damage(n):
	health = health - n
	enemy_sprite.animation = "hit"
	await get_tree().create_timer(0.3).timeout
	enemy_sprite.animation = "idle"
	
		
	if (health <= 0):
		enemy_sprite.play("death")
		

