extends Sprite2D

var count : int = 0
var apple : bool = true
@onready var timer = $Timer

signal apple_picked

# Called when the node enters the scene tree for the first time.
func _ready():
	pass

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(_delta):
	pass

func _on_area_2d_body_entered(body):
	$PickUp.play()
	if body.is_in_group("player"): # so only the player can hit the apple area
		emit_signal("apple_picked")
		apple_test()
		timer.start(0.1)

func apple_test():
	if apple == true:
		count = count + 1
		apple = false


func _on_timer_timeout():
	queue_free()
