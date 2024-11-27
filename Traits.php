<?php
trait Logger {
    public function log($message) {
        echo "Log: $message\n";
    }
}

class Application {
    use Logger;

    public function run() {
        $this->log("Application is running");
    }
}

$app = new Application();
$app->run();
?>
