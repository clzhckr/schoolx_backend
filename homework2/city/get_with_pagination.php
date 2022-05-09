<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

include_once '../config/config.php';
include_once '../shared/utilities.php';
include_once '../config/database.php';
include_once '../models/city.php';

$utilities = new Utilities();
$database = new Database();
$db = $database->getConnection();
$city = new city($db);

$stmt = $city->readPaging($from_record_num, $records_per_page);
$num = $stmt->rowCount();

if ($num>0) {

    $city_arr=array();
    $city_arr["records"]=array();
    $city_arr["paging"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)) {
        extract($row, 1);
        $city_arr["records"][] = $row;
    }
    
    $total_rows=$city->count();
    $page_url="{$home_url}city/get_with_pagination.php?";
    $paging=$utilities->getPaging($page, $total_rows, $records_per_page, $page_url);
    $city_arr["paging"]=$paging;
    
    http_response_code(200);
    
    echo json_encode($city_arr);

} else {
    
    http_response_code(404);
    
    echo json_encode(array("message" => "Записи не найдены."), JSON_UNESCAPED_UNICODE);
}
