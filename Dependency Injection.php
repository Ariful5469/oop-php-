<?php
class Logger {
    public function log($message) {
        echo "Log: $message\n";
    }
}

class Service {
    private $logger;

    public function __construct(Logger $logger) {
        $this->logger = $logger;
    }

    public function execute() {
        $this->logger->log("Service executed");
    }
}

$service = new Service(new Logger());
$service->execute();
?>
