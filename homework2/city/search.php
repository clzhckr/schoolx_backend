<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

include_once '../config/database.php';
include_once '../models/city.php';

$database = new Database();
$db = $database->getConnection();

$city = new city($db);

$keywords=isset($_GET["s"]) ? $_GET["s"] : "";

$stmt = $city->search($keywords);
$num = $stmt->rowCount();

if ($num>0) {

    $city_arr=array();
    $city_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        $city_arr["records"][] = $row;
    }

    http_response_code(200);

    echo json_encode($city_arr);
}

else {
    http_response_code(404);

    echo json_encode(array("message" => "Записи не найдены."), JSON_UNESCAPED_UNICODE);
}
?>