<?php
class Example {
    public $publicVar = "Public";
    private $privateVar = "Private";
    protected $protectedVar = "Protected";

    public function show() {
        echo $this->publicVar . "\n";
        echo $this->privateVar . "\n";
        echo $this->protectedVar . "\n";
    }
}

$obj = new Example();
$obj->show();

?>
