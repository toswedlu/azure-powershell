namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>node type capability</summary>
    public partial class NodeTypeCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapability,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapabilityInternal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapabilityInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for NodeType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapabilityInternal.NodeType { get => this._nodeType; set { {_nodeType = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INodeTypeCapabilityInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>note type name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="NodeType" /> property.</summary>
        private string _nodeType;

        /// <summary>note type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string NodeType { get => this._nodeType; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="NodeTypeCapability" /> instance.</summary>
        public NodeTypeCapability()
        {

        }
    }
    /// node type capability
    public partial interface INodeTypeCapability :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>note type name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"note type name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>note type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"note type",
        SerializedName = @"nodeType",
        PossibleTypes = new [] { typeof(string) })]
        string NodeType { get;  }
        /// <summary>The status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }

    }
    /// node type capability
    internal partial interface INodeTypeCapabilityInternal

    {
        /// <summary>note type name</summary>
        string Name { get; set; }
        /// <summary>note type</summary>
        string NodeType { get; set; }
        /// <summary>The status</summary>
        string Status { get; set; }

    }
}