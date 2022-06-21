<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Web_Persona_Actualizar.aspx.cs" Inherits="Systm_Web.Web_Persona_Actualizar" %>

<!DOCTYPE html>



<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title></title>
  
  <html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title></title>
  
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">

  <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css">

  <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css">

  <link rel="stylesheet" href="bower_components/Ionicons/css/ionicons.min.css">

  <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
  
  <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css">

  <link rel="stylesheet" href="bower_components/morris.js/morris.css">

  <link rel="stylesheet" href="bower_components/jvectormap/jquery-jvectormap.css">

  <link rel="stylesheet" href="bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css">

  <link rel="stylesheet" href="bower_components/bootstrap-daterangepicker/daterangepicker.css">

  <link rel="stylesheet" href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">

 
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
    <style type="text/css">
        .auto-style6 {
            position: relative;
            width: 100%;
            padding: 10px;
            overflow: hidden;
            left: 0px;
            top: -50px;
        }
        </style>
</head>
<body class="hold-transition skin-blue sidebar-mini">






<div class="wrapper">



  <header class="main-header">
    
      <span class="logo-lg"><b></b></span>
    </a>
    
    <nav class="navbar navbar-static-top">
     
      <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
        <span class="sr-only"></span>
      </a>




      <div class="navbar-custom-menu">
        <ul class="nav navbar-nav">
          <!-- Messages: style can be found in dropdown.less-->
          
             
      <!-- Sidebar user panel -->
   

           
            <ul class="dropdown-menu">
              <li class="header"></li>
              <li>
               
                <ul class="menu">
                  
              
                  
                    
                </ul>
           
              
            </ul>
          </li>
          <!-- Notifications: style can be found in dropdown.less -->
         
            </a>
            <ul class="dropdown-menu">
              <li class="header"></li>
              <li>
                <!-- inner menu: contains the actual data -->
                <ul class="menu">
                  <li>
                    <a href="#">
                      <i class=""></i> 
                    </a>
                  </li>
                  <li>
                    <a href="#">
                      <i class=""></i> 
                    </a>
                  </li>
                  <li>
                    <a href="#">
                      <i class=""></i> 
                    </a>
                  </li>
                  <li>
                    <a href="#">
                      <i class=""></i> 
                    </a>
                  </li>
                  <li>
                    <a href="#">
                      <i class="fa fa-user text-red"></i> 
                    </a>
                  </li>
                </ul>
              </li>
              <li class="footer"><a href="#"></a></li>
            </ul>
          </li>
          <!-- Tasks: style can be found in dropdown.less -->
          <li class="">
            <a href="#" class="" data-toggle="">
              <i class=""></i>
              <span class="label label-danger"></span>
            </a>
            <ul class="dropdown-menu">
              <li class="header"></li>
              <li>
                <!-- inner menu: contains the actual data -->
                <ul class="menu">
                  <li><!-- Task item -->
                    <a href="#">
                      <h3>
            
                        <small class="pull-right"></small>
                      </h3>
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-aqua" style="width: 20%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                          <span class="sr-only"></span>
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                      <h3>
                
                        <small class="pull-right"></small>
                      </h3>
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-green" style="width: 40%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                          <span class="sr-only"></span>
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                      <h3>
                  
                        <small class="pull-right"></small>
                      </h3>
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-red" style="width: 60%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                          <span class="sr-only"></span>
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                      <h3>
                       
                        <small class="pull-right"></small>
                      </h3>
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-yellow" style="width: 80%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                          <span class="sr-only"></span>
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                </ul>
              </li>
              <li class="footer">
                <a href="#"></a>
              </li>
            </ul>
          </li>
         
          <li class="dropdown user user-menu">
            
            <ul class="dropdown-menu">
              <!-- User image -->
              <li class="user-header">
                

                <p>
                
                  <small></small>
                </p>
              </li>
              <!-- Menu Body -->
              <li class="user-body">
                <div class="row">
                  <div class="col-xs-4 text-center">
                    <a href="#"></a>
                  </div>
                  <div class="col-xs-4 text-center">
                    <a href="#"></a>
                  </div>
                  <div class="col-xs-4 text-center">
                    <a href="#"></a>
                  </div>
                </div>
                <!-- /.row -->
              </li>
              <!-- Menu Footer-->
              <li class="user-footer">
                <div class="pull-left">
                  <a href="#" class="btn btn-default btn-flat"></a>
                </div>
                <div class="pull-right">
                  <a href="#" class="btn btn-default btn-flat"></a>
                </div>
              </li>
            </ul>
          </li>
          
          <li>
            <a href="#" data-toggle="control-sidebar"><i class=""></i></a>
          </li>
        </ul>
      </div>
    </nav>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="auto-style6">
        
        
      </div>
      
      <!-- search form -->
         <div class="user-panel">
        <div class="pull-left image">
          <img src="iconos/admin.jpg" class="img-circle" alt="User Image">
        </div>
        <div class="pull-left info">
          <p>Administrador</p>
          <a href="#"><i class="fa fa-circle text-success"></i> Conectado</a>
        </div>
      </div>
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      <ul class="sidebar-menu" data-widget="tree">
        
            
            </span>
          </a>
          
        </li>
       
          <br>

          </a>
          <ul class="treeview-menu">
            <li><a href="pages/layout/top-nav.html"><i class="fa fa-circle-o"></i> </a></li>
            <li><a href="pages/layout/boxed.html"><i class="fa fa-circle-o"></i> </a></li>
            <li><a href="pages/layout/fixed.html"><i class="fa fa-circle-o"></i> </a></li>
            <li><a href="pages/layout/collapsed-sidebar.html"><i class="fa fa-circle-o"></i> </a></li>
          </ul>
        </li>



            <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Persona</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Web_Persona.aspx"><i class="fa fa-circle-o"> Registrar Persona</i></a></li>
           
            


          </ul>
        </li>

                 
        </li>

            <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Propietario</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Web_Propietario.aspx"><i class="fa fa-circle-o"> Registrar Propietario</i></a></li>
           
            


          </ul>
        </li>


          
       

           <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Mascota</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="web_mascota.aspx"><i class="fa fa-circle-o"> Registrar Mascota</i></a></li>
           
          </ul>
        </li>

                 
        </li>
           <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Edificio</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Web_Edificio.aspx"><i class="fa fa-circle-o"> Registrar Edificio</i></a></li>
           
            


          </ul>
        </li>

              <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Departamento</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Web_Departamento.aspx"><i class="fa fa-circle-o"> Registrar Departamento</i></a></li>
           
            


          </ul>
        </li>

                 
     </li>
       
             <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Mantenimiento</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Web_Mantenimiento.aspx"><i class="fa fa-circle-o"> Registrar Mantenimiento</i></a></li>
           
            


          </ul>
        </li>

                 
     </li>
       
          

        <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Incidente</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="web_incidente.aspx"><i class="fa fa-circle-o"> Registrar Incidente</i></a></li>
           
            
          </ul>
        </li>


     



                 
       


        <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Visita</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="web_visita.aspx"><i class="fa fa-circle-o"> Registrar Visita</i></a></li>
           
            
          </ul>
        </li>


     


          

           <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Usuario</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
        <li><a href="web_Usuario.aspx"><i class="fa fa-circle-o"> Registrar Usuario</i></a></li>
           
          </ul>
        </li>






         
           <li class="treeview">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Salir</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
       
             <li><a href="Web_Login.aspx"><i class="fa fa-circle-o"> Cerrar </i></a></li>
            
          </ul>
        </li>








        <li>
          
            </span>
          </a>
        </li>
       
        <li class="treeview">
          
          </a>
         
        </li>
       
           
          
            </span>
          </a>
        </li>

        <li>
          
            </span>
          </a>
        </li>
       
        
      </ul>
    </section>
    <!-- /.sidebar -->
  </aside>





  <!-- formularioss -->










    



    

      
    <form id="form1" runat="server">

  <div class="content-wrapper">
   
 


      <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title"></h3>

          
            <asp:Label ID="txtcodigos" runat="server" style="color: #FFFFFF; font-family: Arial"></asp:Label>

          
        </div>
        <!-- /.box-header -->
        <div class="box-body">
          <div class="row">
            <div class="col-md-6">
              <div class="form-group">
            
              <!-- dividir ventana -->
            
             
                



                 <div class="form-group">
                  <label for="exampleInputEmail1">Dni</label>
               
                                          <asp:TextBox ID="txtruc"  class="form-control"  placeholder="Ingrese Dni" runat="server" ></asp:TextBox>



                </div>


                  
           <div class="form-group">
                  <label for="exampleInputEmail1">Nombres</label>


                     <asp:TextBox ID="txtnombre"  class="form-control"  placeholder="Ingrese Nombres " runat="server"></asp:TextBox>




                </div>


                 <div class="form-group">
                  <label for="exampleInputEmail1">Apellidos</label>
               
                                          <asp:TextBox ID="txtdireccion"  class="form-control"  placeholder="Ingrese Apellidos" runat="server" ></asp:TextBox>




            

              


                       </div>

 
                   


              </div>
              <!-- /.form-group -->
            </div>






            <!-- /.col -->
            <div class="col-md-6">


              <!-- /.form-group -->
              <div class="form-group">
                <div class="form-group">
            
              <!-- dividir ventana -->
            
             


                        
         



                 <div class="form-group">
                  <label for="exampleInputEmail1">Telefono</label>
               
                                          <asp:TextBox ID="txttelefono"  class="form-control"  placeholder="Ingrese Telefono" runat="server" ></asp:TextBox>



                </div>




               







                  
   
     
                 <div class="form-group">
                  <label for="exampleInputEmail1">Fecha</label>
               
                                          <asp:TextBox ID="txtciudad"  class="form-control"  placeholder="Ingrese Fecha" runat="server" ></asp:TextBox>



           







         
                <!-- /.input group -->
              </div>
              <!-- /.form group -->

            

              <div class="form-group">
               

                 <div class="form-group">
           
                </div>


              </div>





              </div>
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
            <asp:Label ID="txtsalida" runat="server" BackColor="White" BorderColor="White" ForeColor="White"></asp:Label>
        </div>

<div class="box-footer">
                    <label>


    <asp:Button ID="Button1" runat="server" class="btn btn-success" Height="39px" Text="Actualizar" Width="126px" OnClick="Button1_Click" />
                </label>

                   <label>      <asp:Button ID="Button4" runat="server" class="btn btn-warning" Height="39px" Text="Eliminar" Width="113px" OnClick="Button4_Click" />

          





              </div>
<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>








        <!-- /.box-body -->
       
      <!-- /.box -->

   
            
          
            </div>
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col (right) -->
      </div>
      <!-- /.row -->

    </section>
    <!-- /.content -->
  </div>

</form>


      


  <!-- /.content-wrapper -->

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Create the tabs -->
    <ul class="nav nav-tabs nav-justified control-sidebar-tabs">
      <li><a href="#control-sidebar-home-tab" data-toggle="tab"><i class="fa fa-home"></i></a></li>
      <li><a href="#control-sidebar-settings-tab" data-toggle="tab"><i class="fa fa-gears"></i></a></li>
    </ul>
    <!-- Tab panes -->
    <div class="tab-content">
      <!-- Home tab content -->
      <div class="tab-pane" id="control-sidebar-home-tab">
        <h3 class="control-sidebar-heading">Recent Activity</h3>
        <ul class="control-sidebar-menu">
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-birthday-cake bg-red"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Langdon's Birthday</h4>

                <p>Will be 23 on April 24th</p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-user bg-yellow"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Frodo Updated His Profile</h4>

                <p>New phone +1(800)555-1234</p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-envelope-o bg-light-blue"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading"></h4>

                <p></p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-file-code-o bg-green"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading"></h4>

                <p></p>
              </div>
            </a>
          </li>
        </ul>
        <!-- /.control-sidebar-menu -->

        <h3 class="control-sidebar-heading"></h3>
        <ul class="control-sidebar-menu">
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
               
                <span class="label label-danger pull-right"></span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-danger" style="width: 70%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
                Update Resume
                <span class="label label-success pull-right">95%</span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-success" style="width: 95%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
        
                <span class="label label-warning pull-right"></span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-warning" style="width: 50%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
         
                <span class="label label-primary pull-right"></span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-primary" style="width: 68%"></div>
              </div>
            </a>
          </li>
        </ul>
        <!-- /.control-sidebar-menu -->

      </div>
      <!-- /.tab-pane -->
      <!-- Stats tab content -->
      <div class="tab-pane" id="control-sidebar-stats-tab"></div>
      <!-- /.tab-pane -->
      <!-- Settings tab content -->
      <div class="tab-pane" id="control-sidebar-settings-tab">
        <form method="post">
          <h3 class="control-sidebar-heading"></h3>

          <div class="form-group">
            <label class="control-sidebar-subheading">
          
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
             
            </p>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
        
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
            
            </p>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
             
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
             
            </p>
          </div>
          <!-- /.form-group -->

          <h3 class="control-sidebar-heading"></h3>

          <div class="form-group">
            <label class="control-sidebar-subheading">
        
              <input type="checkbox" class="pull-right" checked>
            </label>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
         
              <input type="checkbox" class="pull-right">
            </label>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
              
              <a href="javascript:void(0)" class="text-red pull-right"><i class="fa fa-trash-o"></i></a>
            </label>
          </div>
          <!-- /.form-group -->
        </form>
      </div>
      <!-- /.tab-pane -->
    </div>
  </aside>
  <!-- /.control-sidebar -->
  <!-- Add the sidebar's background. This div must be placed
       immediately after the control sidebar -->
  <div class="control-sidebar-bg"></div>
</div>
<!-- ./wrapper -->

<!-- jQuery 3 -->
<script src="bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- Select2 -->
<script src="bower_components/select2/dist/js/select2.full.min.js"></script>
<!-- InputMask -->
<script src="plugins/input-mask/jquery.inputmask.js"></script>
<script src="/plugins/input-mask/jquery.inputmask.date.extensions.js"></script>
<script src="plugins/input-mask/jquery.inputmask.extensions.js"></script>
<!-- date-range-picker -->
<script src="bower_components/moment/min/moment.min.js"></script>
<script src="bower_components/bootstrap-daterangepicker/daterangepicker.js"></script>
<!-- bootstrap datepicker -->
<script src="bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"></script>
<!-- bootstrap color picker -->
<script src="bower_components/bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js"></script>
<!-- bootstrap time picker -->
<script src="plugins/timepicker/bootstrap-timepicker.min.js"></script>
<!-- SlimScroll -->
<script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- iCheck 1.0.1 -->
<script src="plugins/iCheck/icheck.min.js"></script>
<!-- FastClick -->
<script src="bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="dist/js/demo.js"></script>
<!-- Page script -->
<script>
    $(function () {
        //Initialize Select2 Elements
        $('.select2').select2()

        //Datemask dd/mm/yyyy
        $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
        //Datemask2 mm/dd/yyyy
        $('#datemask2').inputmask('mm/dd/yyyy', { 'placeholder': 'mm/dd/yyyy' })
        //Money Euro
        $('[data-mask]').inputmask()

        //Date range picker
        $('#reservation').daterangepicker()
        //Date range picker with time picker
        $('#reservationtime').daterangepicker({ timePicker: true, timePickerIncrement: 30, format: 'MM/DD/YYYY h:mm A' })
        //Date range as a button
        $('#daterange-btn').daterangepicker(
          {
              ranges: {
                  'Today': [moment(), moment()],
                  'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                  'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                  'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                  'This Month': [moment().startOf('month'), moment().endOf('month')],
                  'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
              },
              startDate: moment().subtract(29, 'days'),
              endDate: moment()
          },
          function (start, end) {
              $('#daterange-btn span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'))
          }
        )

        //Date picker
        $('#datepicker').datepicker({
            autoclose: true
        })

        //iCheck for checkbox and radio inputs
        $('input[type="checkbox"].minimal, input[type="radio"].minimal').iCheck({
            checkboxClass: 'icheckbox_minimal-blue',
            radioClass: 'iradio_minimal-blue'
        })
        //Red color scheme for iCheck
        $('input[type="checkbox"].minimal-red, input[type="radio"].minimal-red').iCheck({
            checkboxClass: 'icheckbox_minimal-red',
            radioClass: 'iradio_minimal-red'
        })
        //Flat red color scheme for iCheck
        $('input[type="checkbox"].flat-red, input[type="radio"].flat-red').iCheck({
            checkboxClass: 'icheckbox_flat-green',
            radioClass: 'iradio_flat-green'
        })

        //Colorpicker
        $('.my-colorpicker1').colorpicker()
        //color picker with addon
        $('.my-colorpicker2').colorpicker()

        //Timepicker
        $('.timepicker').timepicker({
            showInputs: false
        })
    })
</script>
</body>
</html>