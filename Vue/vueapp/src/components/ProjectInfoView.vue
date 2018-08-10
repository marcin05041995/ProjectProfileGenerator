<template>
    <div id="info">
        <h1 style="margin-top:20px;">Oto wszystkie informacje o projekcie i pracownikach</h1>



        <h1>Pracownik</h1>
        <div class="col-lg-3"></div>
        <div class="col-lg-6">
        <table class="table table-hover" >
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Imie</th>
                    <th>Nazwisko</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="emp in employees" :key="emp.Id">
                    <td align="left">{{emp.profile.id}}</td>
                    <td align="left">{{emp.profile.name}}</td>
                    <td align="left">{{emp.profile.lastName}}</td>
                </tr>
            </tbody>
        </table>
        </div>
        <div class="col-lg-3"></div>


        <div style="clear:both"></div>
        <h1>Projekt</h1>
        <div class="col-lg-1"></div>
        <div class="col-lg-10">
      <table class="table table-hover">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Projekt</th>
                    <th>Sektor</th>
                    <th>Technologie</th>
                    <th>Data początkowa</th>
                    <th>Data końcowa</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                <tr v-for="p in projects" :key="p.Id" >
                    <td align="left">{{p.profileProject.id}}</td>
                    <td align="left">{{p.profileProject.name}}</td>
                    <td align="left">{{p.profileProject.clientSector}}</td>
                    <td align="left">{{p.profileProject.technologies}}</td>
                    <td align="left">{{p.profileProject.startDate}}</td>
                    <td align="left">{{p.profileProject.endDate}}</td>
                    <!-- <td style="margin-left:5px;">
                      <router-link to="/editproject"><button class="btn btn-primary">Edytuj</button></router-link>
                      <button class="btn btn-danger">Usuń</button>
                      <router-link to="projectinfoview"><button class="btn btn-info">Informacje</button></router-link>
                    </td> -->
                </tr>
            </tbody>
        </table></div>
        <div class="col-lg-10"></div>


    </div>
</template>

<script>
import axios from 'axios';

export default {
  data() {
    return {
      projects: [],
      employees:[],
      errors: []
    }
  },

  // Fetches posts when the component is created.
  created() {
    axios.get(`http://localhost:4444/api/projects/GetProjects`)
    .then(response => {
      console.log('asdaqwe')
      // JSON responses are automatically parsed.
        this.projects = response.data;
      })
      .catch(e => {
        this.errors.push(e);
      });

      axios.get('http://localhost:4444/api/employees/GetEmployees')
      .then(response=>{
        this.employees=response.data;
      })
  },

  //   methods:{
  //   getID(){
  //       axios.get('http://localhost:4444/api/projects/GetProject?id=86904cf4-0a67-487c-3f3c-08d5fc3f39c7')
  //       .then(response =>{
  //         this.projects=response.data;
  //       })
  //   }
  // }
};

</script>

<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
