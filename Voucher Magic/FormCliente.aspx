<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormCliente.aspx.cs" Inherits="Voucher_Magic.FormCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




<script src="Scripts/jquery-3.3.1.js" type="text/javascript"></script>
<script src="Scripts/bootstrap.js" type="text/javascript"></script>
<script src="/bundles/WebFormsJs?v=N8tymL9KraMLGAMFuPycfH3pXe6uUlRXdhtYv8A_jUU1" type="text/javascript"></script>
<div class="aspNetHidden">

	<input type="hidden" name="__VIEWSTATEGENERATOR" id="__VIEWSTATEGENERATOR" value="A7163D51">
</div>
        <script type="text/javascript">
            //<![CDATA[
            Sys.WebForms.PageRequestManager._initialize('ctl00$ctl09', 'ctl01', [], [], [], 90, 'ctl00');
//]]>
</script>

   <div class="container body-content">
        <h2>Formulario de registro</h2>
        <div class="titulos">
            <h3>COMPLETA TUS DATOS PERSONALES</h3>
            <p>*Campos obligatorios</p>
        </div>

       <%--Ingreso Nombre--%> 
        <div class="bloque2">
            <div class="bloque2Col">
                <p>Nombre*</p>
                <asp:TextBox ID="TxtNombreCl" placeholder="Nombre" AutoPostBack="true" MaxLength="50" AutoCompleteType="FirstName" runat="server"></asp:TextBox>
               </div>
         </div>
        <%--Ingreso Apellido--%>
        <div class="bloque2">
            <div class="bloque2Col">
                <p>Apellido*</p>
                <asp:TextBox ID="TxtApellidoCl" placeholder="Apellido" AutoPostBack="true" MaxLength="50" AutoCompleteType="LastName" ValidateRequestMode="Enabled" runat="server"></asp:TextBox>
              </div>
        </div>
             <%--Numero DNI---%>
            <div class="bloque2">
                <div class="bloque2Col">
                    <p>N° Documento*</p>
                        <asp:TextBox ID="TxtDniCl" MaxLength="8" AutoPostBack="true" placeholder="Número documento" runat="server"></asp:TextBox>
                    </div>
                </div>
        <%--Ingreso Mail--%>
        <div class="bloque2">
            <div class="bloque2Col">
                <p>Email*</p>
                <asp:TextBox ID="TxtMailCl" AutoPostBack="true" MaxLength="50" AutoCompleteType="Email" ValidateRequestMode="Enabled" runat="server" placeholder="direction@example.com.ar"></asp:TextBox>
            </div>          
        </div>
        <%--Ingreso Direccion de la casa--%>
        <div class="bloque2">
                <div class="bloque2Col">
                    <p>Direccion*</p>
                      <asp:TextBox ID="TxtDirCl" AutoPostBack="true" MaxLength="100" AutoCompleteType="HomeStreetAddress" ValidateRequestMode="Enabled" runat="server" placeholder="Direccion" ></asp:TextBox>
                </div>
            </div>
        <%--Ingresa Ciudad--%>
            <div class="bloque2">
                <div class="bloque2Col">
                    <p>Ciudad</p>
                        <asp:TextBox ID="TxtCiudadCl" AutoPostBack="true" AutoCompleteType="BusinessCity" placeholder="Ciudad" runat="server"></asp:TextBox>
                     </div>
            </div>
    
            <%--Ingrese Codigo Postal --%>
        <div class="bloque2">
            <div class="bloque2Col">
                <p>Codigo Postal</p>
                 <asp:TextBox ID="TxtCPCl" MaxLength="4" AutoPostBack="true" placeholder="CP" runat="server"></asp:TextBox>
            </div>
        </div>
       
      
            <%---<div class="bloque2">
                <div class="bloque2Col">
                    <p>Fecha&nbsp;de&nbsp;nacimiento*</p>

                    <input name="_D:day" value=" " type="hidden"><select id="day" dir="ltr" name="day" onblur="verificarCamposFechasCL(this);" class="fecha" size="1"><option value="">Día</option><option value="1">1</option><option value="2">2</option><option value="3">3</option><option value="4">4</option><option value="5">5</option><option value="6">6</option><option value="7">7</option><option value="8">8</option><option value="9">9</option><option value="10">10</option><option value="11">11</option><option value="12">12</option><option value="13">13</option><option value="14">14</option><option value="15">15</option><option value="16">16</option><option value="17">17</option><option value="18">18</option><option value="19">19</option><option value="20">20</option><option value="21">21</option><option value="22">22</option><option value="23">23</option><option value="24">24</option><option value="25">25</option><option value="26">26</option><option value="27">27</option><option value="28">28</option><option value="29">29</option><option value="30">30</option><option value="31">31</option></select><input name="_D:month" value=" " type="hidden"><select id="month" dir="ltr" name="month" onblur="verificarCamposFechasCL(this);" class="fecha" onchange="monthChanged(this.value)" size="1"><option value="">Mes</option><option value="01">Ene</option><option value="02">Feb</option><option value="03">Mar</option><option value="04">Abr</option><option value="05">May</option><option value="06">Jun</option><option value="07">Jul</option><option value="08">Ago</option><option value="09">Sep</option><option value="10">Oct</option><option value="11">Nov</option><option value="12">Dic</option></select><input type="hidden" id="month_1" name="month_1" value="Ene">
                    <input type="hidden" id="month_2" name="month_2" value="Feb">
                    <input type="hidden" id="month_3" name="month_3" value="Mar">
                    <input type="hidden" id="month_4" name="month_4" value="Abr">
                    <input type="hidden" id="month_5" name="month_5" value="May">
                    <input type="hidden" id="month_6" name="month_6" value="Jun">
                    <input type="hidden" id="month_7" name="month_7" value="Jul">
                    <input type="hidden" id="month_8" name="month_8" value="Ago">
                    <input type="hidden" id="month_9" name="month_9" value="Sep">
                    <input type="hidden" id="month_10" name="month_10" value="Oct">
                    <input type="hidden" id="month_11" name="month_11" value="Nov">
                    <input type="hidden" id="month_12" name="month_12" value="Dic"><input name="_D:year" value=" " type="hidden"><select id="year" dir="ltr" name="year" onblur="verificarCamposFechasCL(this);" class="fecha" onchange="yearChanged(this.value)" size="1"><option value="">Año</option><option value="2019">2019</option><option value="2018">2018</option><option value="2017">2017</option><option value="2016">2016</option><option value="2015">2015</option><option value="2014">2014</option><option value="2013">2013</option><option value="2012">2012</option><option value="2011">2011</option><option value="2010">2010</option><option value="2009">2009</option><option value="2008">2008</option><option value="2007">2007</option><option value="2006">2006</option><option value="2005">2005</option><option value="2004">2004</option><option value="2003">2003</option><option value="2002">2002</option><option value="2001">2001</option><option value="2000">2000</option><option value="1999">1999</option><option value="1998">1998</option><option value="1997">1997</option><option value="1996">1996</option><option value="1995">1995</option><option value="1994">1994</option><option value="1993">1993</option><option value="1992">1992</option><option value="1991">1991</option><option value="1990">1990</option><option value="1989">1989</option><option value="1988">1988</option><option value="1987">1987</option><option value="1986">1986</option><option value="1985">1985</option><option value="1984">1984</option><option value="1983">1983</option><option value="1982">1982</option><option value="1981">1981</option><option value="1980">1980</option><option value="1979">1979</option><option value="1978">1978</option><option value="1977">1977</option><option value="1976">1976</option><option value="1975">1975</option><option value="1974">1974</option><option value="1973">1973</option><option value="1972">1972</option><option value="1971">1971</option><option value="1970">1970</option><option value="1969">1969</option><option value="1968">1968</option><option value="1967">1967</option><option value="1966">1966</option><option value="1965">1965</option><option value="1964">1964</option><option value="1963">1963</option><option value="1962">1962</option><option value="1961">1961</option><option value="1960">1960</option><option value="1959">1959</option><option value="1958">1958</option><option value="1957">1957</option><option value="1956">1956</option><option value="1955">1955</option><option value="1954">1954</option><option value="1953">1953</option><option value="1952">1952</option><option value="1951">1951</option><option value="1950">1950</option><option value="1949">1949</option><option value="1948">1948</option><option value="1947">1947</option><option value="1946">1946</option><option value="1945">1945</option><option value="1944">1944</option><option value="1943">1943</option><option value="1942">1942</option><option value="1941">1941</option><option value="1940">1940</option><option value="1939">1939</option><option value="1938">1938</option><option value="1937">1937</option><option value="1936">1936</option><option value="1935">1935</option><option value="1934">1934</option><option value="1933">1933</option><option value="1932">1932</option><option value="1931">1931</option><option value="1930">1930</option><option value="1929">1929</option><option value="1928">1928</option><option value="1927">1927</option><option value="1926">1926</option><option value="1925">1925</option><option value="1924">1924</option><option value="1923">1923</option><option value="1922">1922</option><option value="1921">1921</option><option value="1920">1920</option><option value="1919">1919</option><option value="1918">1918</option><option value="1917">1917</option><option value="1916">1916</option><option value="1915">1915</option><option value="1914">1914</option><option value="1913">1913</option><option value="1912">1912</option><option value="1911">1911</option><option value="1910">1910</option><option value="1909">1909</option></select><div class="validRegistro">
                        <div class="valError" id="errorFecha"></div>
                        <div class="valOK" id="okFecha"></div>
                    </div>
                </div>
                
            </div>
           ---%>
            <%--<div class="bloque2">
                <div class="bloque2Col">
                    <p>Celular*</p>
                    <input id="celular" maxlength="12" name="celular" onblur="validarCelular(this);" value="" type="text"><input name="_D:celular" value=" " type="hidden"><div class="validRegistro"><div class="valError" id="errorCel"></div><div class="valOK" id="okCel"></div></div>
                </div>
                
                
                
            </div>--%>
            <asp:Button ID="BtnAplicarCanje" runat="server" Text="Finalizar" OnClick="BtnAplicarCanje_Click" />
    <!--Fin Registro info-->
       </div>


</asp:Content>

 
