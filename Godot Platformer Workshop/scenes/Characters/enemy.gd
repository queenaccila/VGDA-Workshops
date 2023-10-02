extends RigidBody2D

var health = 30
@onready var enemy_sprite = $AnimatedSprite2D

func take_damage(n):
	health = health - n
	enemy_sprite.animation = "hit"
	if (health <= 0):
		enemy_sprite.animation = "death"
		queue_free()
