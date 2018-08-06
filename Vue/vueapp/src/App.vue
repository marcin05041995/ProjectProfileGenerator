<template>
  <div id="app">

 <nav class="navbar navbar-inverse navbar-fixed-top " style="height:70px;">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle"
                  data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <router-link to="/home"><a  class="navbar-brand"
                style="color:white; font-weight:700;"> <img src="./assets/it.png" /></a>
                </router-link>
            </div>
            <div class="navbar-collapse collapse" >
                <ul class="nav navbar-nav" style="margin-top:10px;" >
                    <li > <router-link to="/employee"><a  style="color:white; font-weight:700;">
                      Pracownicy</a></router-link></li>
                    <li> <router-link to="/project"><a  style="color:white; font-weight:700;">
                      Projekty</a></router-link></li>
                </ul>
            </div>
        </div>
    </nav>
    <br/>


    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'Home',
  // name: 'Employee',
  // name: 'Project'
};
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
