<template>
  <div class="projectclass">
  <bt/>
  <h1>Widok projektu</h1>


    <br/><br/><br/>
    <div class="col-lg-3"></div>
    <div class="col-lg-6">
      <router-link to="/addproject"><button class="btn btn-primary"
        style="float:left; margin-bottom:20px;">Dodaj projekt</button></router-link>

          <table class="table table-hover">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Projekt</th>
                    <th>Wykonawca</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td align="left" >1</td>
                    <td align="left">Projekt1</td>
                    <td align="left">Janek</td>
                </tr>
                <tr>
                    <td align="left">2</td>
                    <td align="left">Projekt2</td>
                    <td align="left">Zbyszek</td>
                </tr>
                <tr>
                    <td align="left">3</td>
                    <td align="left">Projekt3</td>
                    <td align="left">Ziomeczek</td>
                </tr>
            </tbody>
        </table>

    </div>
    <div class="col-lg-3"></div>
  </div>
</template>


<script>
export default {
  name: 'Project',
  data() {
    return {
      msg: 'Witaj w aplikacji do zarządzania pracownikami!',
    };
  },
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
