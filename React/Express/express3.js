var express = require("express");
var cors = require("cors");
var bodyParser = require("body-parser");
const e = require("express");

var app = express();
app.use(bodyParser.json());
app.use(cors());


let employees=[
    {"name":"abhishek", "id": 1, "basic":3000},
    {"name":"pratik", "id":2, "basic":4000},
    {"name":"pratham", "id":3, "basic":4000},
    {"name":"asik", "id":4, "basic":4000},
    {"name":"pankaj", "id":5, "basic":4000}

    
]
app.get("/",(req, res)=>{
    res.status(200).json(employees);
})

app.get("/emp/search/:id", (req ,res)=>{
    let found = employees.find(function(item){
        return item.id === parseInt(req.params.id);
    });
    if(found){
        res.status(200).json(found)
    }
    else{
        res.sendStatus(404);
    }
})

app.post("/addemp/:id/:name",(req, res)=>{
    let newItem = {
        id : req.params.id,
        name:req.params.name
    }
        employees.push(newItem);

        res.status(200).json({"message":"Added successfully"});
})

app.listen(4000, (req, res)=>{
    console.log("Listning on port 4000");
})