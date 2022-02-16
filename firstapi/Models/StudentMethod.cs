
        // private readonly IWebHostEnvironment webHostEnvironment;
        // public StudentTable(){}
        // public StudentTable(IWebHostEnvironment _webHostEnvironment){
        //      webHostEnvironment = _webHostEnvironment;
        // }
        
        // public List<StudentTable> getAllData(){
        //     using(var db = new DatabaseTrainingContext()){
        //         List<StudentTable> data = db.StudentTables.ToList();
        //         return data;
        //     }
        // }
        // public StudentTable GetById(int id){
        //         using(var db = new DatabaseTrainingContext()){
        //             StudentTable obj = db.StudentTables.Find(id);
        //             return obj;
        //         }
        //     }

        //     public StudentTable AddStudent(StudentTable obj){
        //         using(var db = new DatabaseTrainingContext()){
        //             var std = db.StudentTables.Add(obj);
        //             db.SaveChanges();
        //             return obj;
        //     } 
        //  }

        //    public StudentTable UpdateStudent(StudentTable obj){
        //         using(var db = new DatabaseTrainingContext()){
        //             var std = db.StudentTables.Update(obj);
        //             db.SaveChanges();
        //             return obj;
        //     } 
        //  }

        //   public StudentTable DeleteStudent(int id){
        //      using(var db = new DatabaseTrainingContext()){
        //             var std = db.StudentTables.Find(id);
        //             db.StudentTables.Remove(std);
        //             db.SaveChanges();
        //             return std;
        //     } 
        // }

        // public StudentTable Login(StudentTable obj){
        //     using(var db = new DatabaseTrainingContext()){
        //             var stdID = db.StudentTables.Find(obj.Id);
        //             var stdPass  = db.StudentTables.Where(x=> x.Password == obj.Password).FirstOrDefault();
        //             if(stdID != null && stdPass != null ){
        //                 return obj;
        //             }else{
        //                 return null;
        //             }
        //     }
        // }

        // public Student Upload(Student obj){
        //     using(var db = new DatabaseTrainingContext()){
        //         string filename = null;
        //         if(obj.file_upload != null){
        //             string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath,"image");
        //             filename = obj.file_upload.FileName;
        //             string filepath = Path.Combine(uploadFolder,filename);
        //             var filestream = new FileStream(filepath,FileMode.Create);
        //             obj.file_upload.CopyTo(filestream);
        //             StudentTable std = new StudentTable();
        //             std.file_upload = "~/image/"+obj.Id+filename;
        //             db.SaveChanges();
                    
        //         }
        //         return obj;
        //     }
        // }
 