extends Label


func _process(_delta):
	self.text = str(Score.score)


func _on_apple_apple_picked():
	Score.score += 1
