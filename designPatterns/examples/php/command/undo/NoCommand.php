<?php

require_once("./Command.php");

class NoCommand implements Command {
	public function execute() { }
	public function undo() { }
}
